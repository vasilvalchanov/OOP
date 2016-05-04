namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Exceptions;
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var shipName = commandArgs[1];
            var destinationName = commandArgs[2];

            var ship = this.GameEngine.Starships.FirstOrDefault(s => s.Name == shipName);
            var destination = this.GameEngine.Galaxy.GetStarSystemByName(destinationName);

            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }

            if (ship.Location.Name == destinationName)
            {
                throw new LocationOutOfRangeException(string.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            
            this.GameEngine.Galaxy.TravelTo(ship, destination);

        }
    }
}
