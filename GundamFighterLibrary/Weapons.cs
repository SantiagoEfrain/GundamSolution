using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{
    public class Weapons
    {
        //Fields
        private string _name;
        private int _damage;
        private int _bonusHitChance;
        private WeaponTypes _type;
   


        //Probs
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public WeaponTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }        
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }        


        //Constructors
        public Weapons(string name, int damage, int bonusHitChance,
             WeaponTypes type)
        {
            Name = name;
            Damage = damage;
            BonusHitChance = bonusHitChance;
            Type = type;
        }
        public Weapons()
        {

        }

        //Methods

        public override string ToString()
        {
            return $"---{Name}---\n" +
                $"Damage: {Damage}\n" +
                $"Bonus Hit Chance: {BonusHitChance}";
        }

    }
}
