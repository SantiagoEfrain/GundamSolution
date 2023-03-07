using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GundamFighterLibrary.CombatFiles
{
    public class BeamRifle  
    {
        public static void DoAttack2(Character attacker, Character defender)
        {
            int roll = new Random().Next(1, 100);
            Thread.Sleep(200);
            if (roll <= attacker.CalcHitChance() - defender.CalcBlock())
            {

                int damageDealt = attacker.Damage;
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack

        public static void DoBattle2(Player player, EnemyMobileSuits enemyMobileSuits)
        {
            DoAttack2(player, enemyMobileSuits);
            if (enemyMobileSuits.Life > 0)
            {
                DoAttack2(enemyMobileSuits, player);
            }
        }

    }
}

