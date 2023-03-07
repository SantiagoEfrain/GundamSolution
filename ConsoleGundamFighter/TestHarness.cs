using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GundamFighterLibrary;
using GundamFighterLibrary.CombatFiles;
using SignatureLibrary;

namespace ConsoleGundamFighter
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {

            Player playerGM = new Player("GM", 10, 10, 10, 80, MSEnums.GM);
            Player playerGuncannon = new Player("Guncannon", 10, 10, 10, 80, MSEnums.Guncannon);
            Player playerRX78 = new Player("Gundam RX-78", 10, 10, 10, 80, MSEnums.RX78);


            Console.WriteLine(playerGM);
            Console.WriteLine();
            Console.WriteLine(playerGuncannon);
            Console.WriteLine();
            Console.WriteLine(playerRX78);
            Console.WriteLine();

            EnemyMobileSuits enemy = EnemyMobileSuits.GetSuit();
            Console.WriteLine(enemy);

            BeamSaber.DoBattle(playerGM, enemy); 






        }
    }
}
