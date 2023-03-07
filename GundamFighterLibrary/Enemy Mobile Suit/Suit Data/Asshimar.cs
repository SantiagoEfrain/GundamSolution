using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{
    public class Asshimar : EnemyMobileSuits
    {

        public Asshimar(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, maxDamage, minDamage)
        {

        }

        public Asshimar()
        {
            MaxLife = 120;
            MaxDamage = 45;
            Name = "Asshimar";
            Life = 120;
            HitChance = 80;
            Block = 18;
            MinDamage = 35;
        }
    }
}
