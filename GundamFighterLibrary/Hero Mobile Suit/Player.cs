using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary
{
    public class Player : Character
    {
        //Fields

        //Props
        public MSEnums ChosenSuit { get; set; }

        //CTORS/Constructors
        public Player(string name, int hitChance, int damage, int block, int maxLife, MSEnums chosenSuit)
            : base(name, hitChance, damage, block, maxLife)
        {
            ChosenSuit = chosenSuit;

            #region Mobile Suit Stats
            switch (ChosenSuit)
            {
                case MSEnums.GM:
                    HitChance += 70;
                    Block += 25;
                    Damage += 10;
                    
                    
                    break;

                case MSEnums.Guncannon:
                    MaxLife += 20;
                    Life += 20;
                    HitChance += 70;
                    Block += 10;
                    Damage += 20;
                    break;

                case MSEnums.RX78:
                    MaxLife += 20;
                    Life += 20;
                    HitChance += 75;
                    Block += 15;
                    Damage += 30;
                    break;

            }
            #endregion
        }

        //Methods



    }
}
