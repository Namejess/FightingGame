using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public interface Character
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Speed { get; set; }
        public int CooldownSpecialAttack { get; set; }
        object name { get; set; }

        public abstract void SpecialAttackMethod(Character character);
        public abstract void AttackMethod(Character character);
        //method loose health
        public void LooseHealth(Character character);

    }


}
