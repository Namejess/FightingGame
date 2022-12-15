//soigneur 
using System;
namespace FightingGame
{
    public class Healer : Character { 
    //constructeur 
    public Healer(string name) : base(name)
    {
        //proprietes
        lifePoint = 200;
        damageMin = 10;
        damageMax = 15;
    }
}
}

