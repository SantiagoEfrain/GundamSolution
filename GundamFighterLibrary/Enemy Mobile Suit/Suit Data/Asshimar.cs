using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{
    public class Asshimar : EnemyMobileSuits
    {

        public bool IsBigSuit { get; set; }

        public Asshimar(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBigSuit) : base(name, hitChance, block, maxLife, maxDamage, minDamage)
        {
            IsBigSuit = isBigSuit;
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
            IsBigSuit = true;
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            //Apply a 50% increase to the Rabbit's block if it's fluffy
            if (IsBigSuit)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
