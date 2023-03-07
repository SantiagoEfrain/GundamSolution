using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GundamFighterLibrary
{
    public class Zaku : EnemyMobileSuits
    {

        //set some values for a basic monster of this type in the 
        //default ctor

        public Zaku(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, maxDamage, minDamage)
        {

        }
        public Zaku()
        {
            //SET Max Values First!!
            MaxLife = 80;
            MaxDamage = 35;
            Name = "Zaku II";
            Life = 80;
            HitChance = 45;
            Block = 20;
            MinDamage = 25;

        }

      

    }
}
