using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball.Models
{
    public class Match
    {
        private Team homeTeam;


        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            if (homeTeam.Name == awayTeam.Name)
            {
                throw new InvalidOperationException("The teams name must be different");
            }

            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }

            set
            {
                

                this.homeTeam = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The id cannot be negavite");
                }

                this.id = value;
            }
        }

        public Team AwayTeam { get; set; }

        public Score Score { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            if (this.Score.HomeTeamGoals > this.Score.AwayTeamGoals)
            {
                return this.HomeTeam;
            }

            return this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(
                "{0}: {1} - {2} {3} {4}",
                this.Id,
                this.HomeTeam.Name,
                this.AwayTeam.Name,
                this.Score.HomeTeamGoals,
                this.Score.AwayTeamGoals);

            return sb.ToString();
        }
    }
}
