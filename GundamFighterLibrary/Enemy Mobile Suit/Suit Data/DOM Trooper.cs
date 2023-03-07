using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{

    public class DOMTrooper : EnemyMobileSuits
    {

        public DOMTrooper(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, maxDamage, minDamage)
        {

        }

        public DOMTrooper()
        {
            MaxLife = 100;
            MaxDamage = 45;
            Name = "DOM Trooper";
            Life = 100;
            HitChance = 55;
            Block = 25;
            MinDamage = 35;
        }
    }
}
