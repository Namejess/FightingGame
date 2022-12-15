using System;
namespace FightingGame
{
	public class Player : Fight
	{
		//constructeur
		public Player(string namePlayer) : base(namePlayer)
		{
            //proprietes
			this.namePlayer = namePlayer;
            lifePoint = 600;
            damageMin = 20;
            damageMax = 40;
        }

        internal bool Feature()
        {
            throw new NotImplementedException();
        }

        internal void gainXP(int v)
        {
            throw new NotImplementedException();
        }
    }
}

