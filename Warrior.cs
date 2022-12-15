//guerrier
using System;
namespace FightingGame
{
	public class Warrior : Character
	{
        //constructeur 
        public Warrior(string name) : base(name)
		{
			//proprietes
			lifePoint = 400;
			damageMin = 50;
			damageMax = 100;
		}
	}
}

