namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Exceptions;
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var attackerName = commandArgs[1];
            var targetName = commandArgs[2];

            var attacker = this.GameEngine.Starships.FirstOrDefault(n => n.Name == attackerName);
            var target = this.GameEngine.Starships.FirstOrDefault(n => n.Name == targetName);

            if (target.Health <= 0 || attacker.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }

            if (attacker.Location != target.Location)
            {
                throw new LocationOutOfRangeException(Messages.NoSuchShipInStarSystem);
            }

            var projectile = attacker.ProduceAttack();
            target.RespondToAttack(projectile);

            Console.WriteLine(Messages.ShipAttacked, attackerName, targetName);

            if (target.Health <= 0)
            {
                Console.WriteLine(Messages.ShipDestroyed, targetName);
            }
        }
    }
}
