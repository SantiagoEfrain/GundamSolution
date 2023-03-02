using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GundamFighterLibrary;
using SignatureLibrary;

namespace ConsoleGundamFighter
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {

            Weapons w1 = new Weapons("Beam Pistol", 20, 10);
            Console.WriteLine();
            Console.WriteLine(w1);

            MobileSuits ms1 = new MobileSuits("GM", 80, 80, 60, 25);
            Console.WriteLine();
            Console.WriteLine(ms1);
            Console.WriteLine("CalcResistance: " + ms1.CalcResistance());
            Console.WriteLine("CalcHitChance: " + ms1.CalcHitChance());
            Console.WriteLine("CalcDamage: " + ms1.CalcDamage());


        }
    }
}
