using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamFighterLibrary.CombatFiles
{
    public class BeamSaber
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            int roll = new Random().Next(1, 90);
            Thread.Sleep(200);
            if (roll <= attacker.CalcHitChance() - defender.CalcBlock())
            {

                int damageDealt = attacker.Damage + 10;
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

        public static void DoBattle(Player player, EnemyMobileSuits enemyMobileSuits)
        {
            DoAttack(player, enemyMobileSuits);
            if (enemyMobileSuits.Life > 0)
            {
                DoAttack(enemyMobileSuits, player);
            }
        }
    }
}
