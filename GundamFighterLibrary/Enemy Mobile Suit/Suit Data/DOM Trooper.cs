using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{

    public class DOMTrooper : EnemyMobileSuits
    {

        public bool IsTriStar { get; set; }

        public DOMTrooper(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isTriStar) : base(name, hitChance, block, maxLife, maxDamage, minDamage)
        {
            IsTriStar = isTriStar;
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
            IsTriStar = true;
        }

        public override int CalcDamage()
        {
            int calculatedDamage = Damage;

            //Apply a 50% increase to the Rabbit's block if it's fluffy
            if (IsTriStar)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }


    }
}
