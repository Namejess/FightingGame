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
            List<Character> characters = new List<Character>
            {
                player1.ChooseCharacter(),
                player2.ChooseCharacter()
            };

            // Handle character attacks based on speed
            characters = characters.OrderByDescending(c => c.Speed).ToList();
            
            //Gameloop
            for (int i = 0; i < characters.Count(); i++)
            {
                var character1 = characters.ElementAt(i);
                var character2 = characters.ElementAt(i);
                
                while (character1.Health > 0 && character2.Health > 0)
                {
                    character1.AttackMethod(character2);
                    Console.WriteLine("Player 1 attack for " + character1.AttackPower + " damage");
                    character2.LooseHealth(character1);
                    Console.WriteLine($"Player 2 has {character2.Health} left");

                    character2.AttackMethod(character1);
                    Console.WriteLine("Player 2 attack for " + character2.AttackPower + " damage");
                    character2.LooseHealth(character1);
                    Console.WriteLine($"Player 1 has {character1.Health} left");

                    if (character2.Health <= 0)
                    {
                        Console.WriteLine("Player 1 wins!");
                        return player1;
                    }
                    else if (character1.Health <= 0)
                    {
                        Console.WriteLine("Player 2 wins!");
                        return player2;
                    }

                }
            
                
            }
            
            return null;
        }
    }


}
