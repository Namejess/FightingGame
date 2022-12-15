//Mage
using System;
namespace FightingGame
{
    public class Magus : Character
    {
        //constructeur 
        public Magus(string name) : base(name)
        {
            //proprietes
            lifePoint = 300;
            damageMin = 30;
            damageMax = 70;
        }
    }
}
