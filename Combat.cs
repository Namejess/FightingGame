using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Combat
    {
        public Combat(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public Player player1;
        public Player player2;

        
        public Player PlayRound()
        {
            // Sort the players' characters by speed
            List<Character> characters = new List<Character>();
            characters.Add(player1.ChooseCharacter());
            characters.Add(player2.ChooseCharacter());
            characters = characters.OrderByDescending(character => character.Speed).ToList();



            // Handle character attacks based on speed
            for (int i = 0; i < characters.Count(); i++)
            {
                var character1 = characters.ElementAt(i);
                var character2 = characters.ElementAt(i);
                if (character1.Health > 0 && character2.Health > 0)
                {
                    character1.AttackMethod(character2);
                    character2.AttackMethod(character1);
                    Console.WriteLine("Player1's character has " + character1.Health + " health left");
                    Console.WriteLine("Player2's character has " + character2.Health + " health left");
                }
            }

            // Update character HP
            foreach (Player player in new[] { this.player1, this.player2 })
            {
                foreach (Character character in characters)
                {
                    character.Health = Math.Max(0, character.Health);
                    Console.WriteLine("Player {0} has {1} HP left", player.name, character.Health);
                }
            }

            // Handle dead characters
            foreach (Player player in new[] { this.player1, this.player2 })
            {
                characters = characters.Where(c => c.Health > 0).ToList();
                Console.WriteLine("Player {0} has {1} characters left", player.name, characters.Count());
            }

            // Check if a player has lost
            if (characters.Count == 0)
            {
                return this.player2;
            }
            else if (characters.Count == 0)
            {
                return this.player1;
            }
            else
            {
                return null;
            }
        }
    }


}
