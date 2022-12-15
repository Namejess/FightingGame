//ici ont gere l'experience !
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public abstract class Character : Fight
    {
        //proprietes
        public int lever;
        public int experience;
        //constructeur

        protected Character(string namePlayer) : base(namePlayer)
        {
            //initialisation personnage avec 0 ex et level 1 au départ
            this.namePlayer = namePlayer;
            lever = 1;
            experience = 0;
        }
        //methode
        public void gainXP(int experience)
        {
            this.experience += experience;
            while (this.experience >= XpRequired())
            {
                //pour infomer le joueur du changement de niveau
                lever += 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bravo vous avez atteint le niveau " + lever + " ! ");

                //ajout caracteristiques supplémentaire
                lifePoint += 10;
                damageMin += 2;
                damageMax += 2;
            }
        }

        public int XpRequired()
        {
            //methode(pokemon "https://www.pokepedia.fr/Courbe_d'experience") pour avoir l'experience requise pour aller au lever next
            //on arrondit le resultat pour pas avoir de float
            return (int)Math.Round(4 * (Math.Pow(lever, 3) / 5));
        }

        public string Feature()
        {
            return this.namePlayer + "\n" +
                "Point de vie : " + lifePoint + "\n" +
                "Niveau : " + lever + "\n" +
                "Points d'experience : " + (experience / XpRequired()) + "\n" +
                "Dégats : " + (+damageMin + ";" + damageMax);

        }


    }

}



//interface Character
//{
//    public int Health { get; set; }
//    public int AttackPower { get; set; }
//    public int Speed { get; set; }
//    public int CooldownSpecialAttack { get; set; }

//    public Character(int health, int attackPower, int speed, int cooldownSpecialAttack)
//    {
//        Health = health;
//        AttackPower = attackPower;
//        Speed = speed;
//        CooldownSpecialAttack = cooldownSpecialAttack;
//    }

//}