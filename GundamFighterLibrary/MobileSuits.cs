﻿namespace GundamFighterLibrary
{
    public class MobileSuits

    {

        //Fields
        private string _name;
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _resistance;

        //Probs
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Resistance
        {
            get { return _resistance; }
            set { _resistance = value; }
        }

        //Constructors

        public MobileSuits(string name, int maxLife, int life, int hitChance, int resistance)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Resistance = resistance;
        }
        public MobileSuits()
        {

        }

        //Methods

        public override string ToString()
        {
            return $"----- {Name} -----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Resistance}";
        }

        public int CalcResistance()
        {
            return Resistance;
        }
        public int CalcHitChance()
        {
            return HitChance;
        }
        public int CalcDamage() { return 0; }
    }
}