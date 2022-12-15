using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    interface Character
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Speed { get; set; }
        public int CooldownSpecialAttack { get; set; }

        public Character(int health, int attackPower, int speed, int cooldownSpecialAttack)
        {
            Health = health;
            AttackPower = attackPower;
            Speed = speed;
            CooldownSpecialAttack = cooldownSpecialAttack;
        }

    }
}
