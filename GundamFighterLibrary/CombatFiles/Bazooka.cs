using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary.CombatFiles
{
    public class Bazooka
    {
        public static void DoAttack3(Character attacker, Character defender)
        {
            int roll = new Random().Next(1, 121);
            Thread.Sleep(200);
            if (roll <= attacker.CalcHitChance() - defender.CalcBlock())
            {

                int damageDealt = attacker.Damage + 30;
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                Console.WriteLine($"\n{attacker.Name} missed!\n");
            }//end else
        }//end DoAttack

        public static void DoBattle3(Player player, EnemyMobileSuits enemyMobileSuits)
        {
            DoAttack3(player, enemyMobileSuits);
            if (enemyMobileSuits.Life > 0)
            {
                DoAttack3(enemyMobileSuits, player);
            }
        }
    }
}
