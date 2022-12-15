using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    //abstract pour pas instancier combat vide soit player or character
    public abstract class Fight
    {
        //propriete en commun
        public string namePlayer { get; set; }
        public bool isDead = false;
        public int lifePoint { get; set; }
        public int damageMin { get; set; }
        public int damageMax { get; set; }
        //initialisation random pour generer nombre aléatoire
        public Random random = new Random();
        

        //constructeur
        public Fight(string namePlayer)
        {
            //this fait référence à l’instance actuelle de la classe
            this.namePlayer = namePlayer;

        }
        //methode commune au fight
        public void Tackle(Fight oneFighter)
        {
            //pour generer un nombre aleatoire entre .. et ..
            int damages = random.Next(damageMin, damageMax);

            oneFighter.LoseLife(damages);
            Console.WriteLine(this.namePlayer + this.lifePoint + " attaque : " + oneFighter.namePlayer);
            Console.WriteLine(oneFighter.namePlayer + "a perdu " + damages + " de point de vie");
            Console.WriteLine("Il reste " + oneFighter.lifePoint + " point de vie à " + oneFighter.namePlayer);
            //condition
            if (oneFighter.isDead)
            {
                Console.WriteLine(oneFighter.namePlayer + " est mort ! ");
            }
        }
        
        public void LoseLife(int lifePoint)
        {
            this.lifePoint -= lifePoint;
            //condition
            if(this.lifePoint <= 0)
            {
                //initialisation a 0 pour pas afficher des nbr negatifs
                this.lifePoint = 0;
                isDead = true;
            }
        }

        public bool IsDead()
        {
            return this.isDead;
        }
    }
}
