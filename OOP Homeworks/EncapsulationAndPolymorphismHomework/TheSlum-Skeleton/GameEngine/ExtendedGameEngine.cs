using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    using TheSlum.Models.Characters;
    using TheSlum.Models.Items;
    using TheSlum.Models.Items.ItemsWithTemporaryEffect;

    public class ExtendedGameEngine : Engine
    {
        protected override void CreateCharacter(string[] inputParams)
        {
            var characterType = inputParams[1];
            var characterId = inputParams[2];
            var characterX = int.Parse(inputParams[3]);
            var characterY = int.Parse(inputParams[4]);
            var characterTeam = (Team)Enum.Parse(typeof(Team), inputParams[5]);
            ExtendedCharacter character = null;

            switch (characterType)
            {
                case "warrior":
                    character = new Warrior(characterId, characterX, characterY, characterTeam);
                    break;
                case "mage":
                    character = new Mage(characterId, characterX, characterY, characterTeam);
                    break;
                case "healer":
                    character = new Healer(characterId, characterX, characterY, characterTeam);
                    break;
                    
            }

            this.characterList.Add(character);
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);

            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItemToCharacter(inputParams);
                    break;
            }
        }

        private void AddItemToCharacter(string[] inputParams)
        {
            var characterName = inputParams[1];
            var itemType = inputParams[2];
            var itemId = inputParams[3];

            var character = this.characterList.FirstOrDefault(c => c.Id == characterName);

            Item item = null;

            switch (itemType)
            {
                case "axe":
                    item = new Axe(itemId);
                    break;
                case "pill":
                    item = new Pill(itemId);
                    break;
                case "injection":
                    item = new Injection(itemId);
                    break;
                case "shield":
                    item = new Shield(itemId);
                    break;  
            }

            character.AddToInventory(item);
        }
    }
}
