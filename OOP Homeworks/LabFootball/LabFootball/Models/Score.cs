using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball.Models
{
    public class Score
    {
        private int homeTeamGoals;

        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The home team goals cannot be negavite");
                }

                this.homeTeamGoals = value;
            }
        }

        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The away team goals cannot be negavite");
                }

                this.awayTeamGoals = value;
            }
        }
    }
}
