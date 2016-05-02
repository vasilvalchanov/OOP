using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball.Models
{
    public class Team
    {
        private const int MinimuAllowedYear = 1850;
        private string name;

        private string nickname;

        private DateTime dateOfFounding;

        private IList<Player> players;

        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The name must be at least 5 symbols long");
                }

                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The nickname must be at least 5 symbols long");
                }

                this.nickname = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.players;
            }

        }

        public void AddPlayer(Player player)
        {
            if (this.Players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName))
            {
                throw new InvalidOperationException("There is already a player with same name");
            }

            this.players.Add(player);

            Console.WriteLine("The player {0} {1} was successfully added", player.FirstName, player.LastName);
        }

        public DateTime DateOfFounding
        {
            get
            {
                return this.dateOfFounding;
            }

            set
            {
                if (value.Year < MinimuAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("Date of founding cannot be earlier than " + MinimuAllowedYear);
                }

                this.dateOfFounding = value;
            }
        }

        public override string ToString()
        {
           var sb = new StringBuilder();
            sb.AppendFormat(
                "{0} --> {1}; Date of founding: {2}",
                this.Name,
                this.Nickname,
                this.DateOfFounding.ToString("dd/MM/yyyy"));

            return sb.ToString();
        }
    }
}
