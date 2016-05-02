using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball.Models
{
    public static class FootballLeague
    {
        private static IList<Match> mathces = new List<Match>();

        private static IList<Team> teams = new List<Team>();

        public static IEnumerable<Match> Matches
        {
            get
            {
                return mathces;
            } 
        }

        public static IEnumerable<Team> Teams
        {
            get
            {
                return teams;
            }
        }

        public static void AddMatch(Match match)
        {
            if (mathces.Any(m => m.Id == match.Id))
            {
                throw new InvalidOperationException("There is already match with the same id");
            }

            mathces.Add(match);

            Console.WriteLine("The match with id {0} was successfully added to the league", match.Id);
        }

        public static void AddTeam(Team team)
        {
            if (teams.Any(t => t.Name == team.Name))
            {
                throw new InvalidOperationException("There is already a team with the same name");
            }

            teams.Add(team);

            Console.WriteLine("The team {0} was successfully added to the league", team.Name);
        }
    }
}
