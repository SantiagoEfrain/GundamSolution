using System;

namespace GundamFighterLibrary
{
    public class EnemyMobileSuits : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }
        }

        public EnemyMobileSuits(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage)
            : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }
        public EnemyMobileSuits()
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} to {MaxDamage}\n";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static EnemyMobileSuits GetSuit()
        {
            // Create a variety of monsters

            Zaku zaku = new();
            DOMTrooper domTrooper = new();
            Asshimar asshimar = new();

            //Add the monsters to a collection
            List<EnemyMobileSuits> suits = new()
            {
               zaku, zaku, zaku,
               domTrooper, domTrooper,
               asshimar
               
            };
            //Pick one at random to place in our dungeon room
            return suits[new Random().Next(suits.Count)];
        }
    }
}