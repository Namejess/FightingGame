using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class ClasseMageHealerWarrior
    {


        public class Healer : Character
        {
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Speed { get; set; }
            public int CooldownSpecialAttack { get; set; }
            public object name { get; set; }

            public void SpecialAttackMethod(Character character)
            {
                character.Health += 8;
            }

            public void AttackMethod(Character character)
            {
                character.Health -= AttackPower;

            }

            public void LooseHealth(Character character)
            {
                character.Health -= character.AttackPower;
            }

            public Healer()
            {
                Health = 20;
                AttackPower = 3;
                Speed = 4;
                CooldownSpecialAttack = 3;
            }
        }

        public class Warrior : Character
        {
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Speed { get; set; }
            public int CooldownSpecialAttack { get; set; }
            public object name { get; set; }

            public void SpecialAttackMethod(Character character)
            {
                character.Health -= character.AttackPower / 2;
            }

            //method to use AttackPower on the character
            public void AttackMethod(Character character)
            {
                character.Health -= AttackPower;
            }

            public void LooseHealth(Character character)
            {
                character.Health -= character.AttackPower;
            }

            public Warrior()
            {
                Health = 30;
                AttackPower = 5;
                Speed = 6;
                CooldownSpecialAttack = 2;
            }
        }

        public class Mage : Character
        {
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Speed { get; set; }
            public int CooldownSpecialAttack { get; set; }
            public object name { get; set; }

            public void SpecialAttackMethod(Character character)
            {
                character.Health -= character.AttackPower * 2;
            }

            public void AttackMethod(Character character)
            {
                character.Health -= AttackPower;

            }

            public void LooseHealth(Character character)
            {
                character.Health -= character.AttackPower;
            }

            public Mage()
            {
                Health = 24;
                AttackPower = 6;
                Speed = 5;
                CooldownSpecialAttack = 2;
                
            }
        }

    }


}
