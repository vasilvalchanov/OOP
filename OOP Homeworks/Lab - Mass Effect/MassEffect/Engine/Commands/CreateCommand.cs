namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Exceptions;
    using MassEffect.GameObjects.Enhancements;
    using MassEffect.GameObjects.Ships;
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var shipType = (StarshipType)Enum.Parse(typeof(StarshipType), commandArgs[1]);
            var shipName = commandArgs[2];
            var shipLocation = commandArgs[3];
            var location = this.GameEngine.Galaxy.GetStarSystemByName(shipLocation);

            this.ValidateName(shipName);

            var ship = this.GameEngine.ShipFactory.CreateShip(shipType, shipName, location);

            for (int i = 4; i < commandArgs.Length; i++)
            {
                var enhancementType = (EnhancementType)Enum.Parse(typeof(EnhancementType), commandArgs[i]);
                var enhancement = this.GameEngine.EnhancementFactory.Create(enhancementType);
                ship.AddEnhancement(enhancement);
            }

            this.GameEngine.Starships.Add(ship);

            Console.WriteLine(Messages.CreatedShip, shipType, shipName);


        }

        private void ValidateName(string name)
        {
            if (this.GameEngine.Starships.Any(n => n.Name == name))
            {
                throw new ShipException(Messages.DuplicateShipName);
            }
            
        }
    }
}
