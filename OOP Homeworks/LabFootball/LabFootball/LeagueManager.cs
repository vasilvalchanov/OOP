using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball
{
    using LabFootball.Models;

    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            var command = inputArgs[0];

            switch (command)
            {
                case "AddTeam":
                    string teamName = inputArgs[1];
                    string teamNickname = inputArgs[2];
                    DateTime dateOfFounding = DateTime.Parse(inputArgs[3]);
                    AddTeam(teamName, teamNickname, dateOfFounding);
                    break;
                case "AddMatch":
                    int matchId = int.Parse(inputArgs[1]);
                    string homeTeam = inputArgs[2];
                    string awayTeam = inputArgs[3];
                    int homeTeamGoals = int.Parse(inputArgs[4]);
                    int awayTeamGoals = int.Parse(inputArgs[5]);
                    AddMatch(matchId, homeTeam, awayTeam, homeTeamGoals, awayTeamGoals);
                    break;
                case "AddPlayerToTeam":
                    string firstName = inputArgs[1];
                    string lastName = inputArgs[2];
                    DateTime dateOfBirth = DateTime.Parse(inputArgs[3]);
                    decimal salary = decimal.Parse(inputArgs[4]);
                    string team = inputArgs[5];
                    AddPlayerToTeam(firstName, lastName, dateOfBirth, salary, team);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMathes();
                    break;
            }
        }

        private static void ListTeams()
        {
            if (!FootballLeague.Teams.Any())
            {
                Console.WriteLine("There are no teams in this league");
            }

            foreach (var team in FootballLeague.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMathes()
        {
            if (!FootballLeague.Matches.Any())
            {
                Console.WriteLine("There are no matches in this league");
            }

            foreach (var match in FootballLeague.Matches.OrderBy(id => id.Id))
            {
                Console.WriteLine(match);
            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, string team)
        {
            var playerTeam = FootballLeague.Teams.FirstOrDefault(t => t.Name == team);

            if (playerTeam == null)
            {
                throw new InvalidOperationException(string.Format("There isn't team {0} in the leagaue", team));
            }

            var player = new Player(firstName, lastName, salary, dateOfBirth, playerTeam);
        }

        private static void AddMatch(int matchId, string homeTeam, string awayTeam, int homeTeamGoals, int awayTeamGoals)
        {
            if (!FootballLeague.Teams.Any(t => t.Name == homeTeam))
            {
                throw new InvalidOperationException(string.Format("There isn't team {0} in the league", homeTeam));
            }

            if (!FootballLeague.Teams.Any(t => t.Name == awayTeam))
            {
                throw new InvalidOperationException(string.Format("There isn't team {0} in the league", awayTeam));
            }

            var firstTeam = FootballLeague.Teams.First(t => t.Name == homeTeam);
            var secondTeam = FootballLeague.Teams.First(t => t.Name == awayTeam);

            var match = new Match(firstTeam, secondTeam, new Score(homeTeamGoals, awayTeamGoals), matchId);
            FootballLeague.AddMatch(match);

        }

        private static void AddTeam(string teamName, string teamNickname, DateTime dateOfFounding)
        {
            
            var team = new Team(teamName, teamNickname, dateOfFounding);
            FootballLeague.AddTeam(team);
        }
    }
}
