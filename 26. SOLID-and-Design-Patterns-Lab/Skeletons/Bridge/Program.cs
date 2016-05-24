namespace RPG
{
    using System;

    using Bridge.Characters;
    using Bridge.Weapons;

    using RPG.Characters;

    public class Program
    {
        static void Main()
        {
            Weapon axe = new Axe();
            Weapon sword = new Sword();
            var axeWarrior = new Warrior(axe);
            var swordWarrior = new Warrior(sword);
            var axeMage = new Mage(axe);
            var swordMage = new Mage(sword);

            Console.WriteLine(axeWarrior);
            Console.WriteLine(swordMage);
            Console.WriteLine(swordWarrior);
            Console.WriteLine(axeMage);
        }
    }
}
