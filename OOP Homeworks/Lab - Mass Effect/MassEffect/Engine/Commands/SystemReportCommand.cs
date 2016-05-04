using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var starSystemName = commandArgs[1];
    
            var destroyedShips =
                this.GameEngine.Starships.Where(s => s.Location.Name == starSystemName)
                    .Where(s => s.Health <= 0).OrderBy(s => s.Name)
                    .ToList();
            var aliveShips = this.GameEngine.Starships.Where(s => s.Location.Name == starSystemName)
                    .Where(s => s.Health > 0).OrderByDescending(s => s.Health).ThenByDescending(s => s.Shields)
                    .ToList();

            var sb = new StringBuilder();
            sb.AppendLine("Intact ships:");

            if (aliveShips.Any())
            {
                sb.AppendLine(string.Join(Environment.NewLine, aliveShips));
            }
            else
            {
                sb.AppendLine("N/A");
            }

            sb.AppendLine("Destroyed ships:");
            if (destroyedShips.Any())
            {
                sb.Append(string.Join(Environment.NewLine, destroyedShips));
            }
            else
            {
                sb.Append("N/A");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
