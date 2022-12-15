using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Player
    {
        public string name;
        
        public Player(string name)
        {
            this.name = name;
        }

        public object ClasseMageHealerWarrior { get; internal set; }

        public Character ChooseCharacter()
        {
            Console.WriteLine("Choose your character! Entrez un chiffre entre : \n[1] Mage \n[2] Warrior \n[3] Healer");
            string character = Console.ReadLine();
            
            switch (character)
            {
                case "1":
                    return new ClasseMageHealerWarrior.Mage();
                case "2":
                    return new ClasseMageHealerWarrior.Warrior();
                case "3":
                    return new ClasseMageHealerWarrior.Healer();
                default:
                    Console.WriteLine("Wrong input");
                    
                    return  ChooseCharacter();
            }
        }
    }
}
