using GundamFighterLibrary;
using GundamFighterLibrary.CombatFiles;
using SignatureLibrary;
using System.Media;
using System.Numerics;
using System.Threading;
using TextToAsciiArt;
using static System.Console;

namespace ConsoleGundamFighter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(Console.WindowWidth);
            //Console.WriteLine(Console.WindowHeight);

            Console.SetWindowSize(200, 40);


            //TODO set window size

            #region Introduction

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer gundamTheme = new SoundPlayer("Gundam Theme compressed.wav");
                gundamTheme.Load();
                gundamTheme.Play();

                Console.Title = "----GUNDAM FIGHTER+----";

                IArtWriter writer = new ArtWriter();
                Console.WriteLine("========================================================================================================================================");
                writer.WriteConsole("GUNDAM    FIGHTER");
                Console.WriteLine("========================================================================================================================================" +
                    "\n\n\n\n");
                Console.Write("Press any key to continue!");
                Console.ReadKey();
                Console.Clear();


                gundamTheme.Stop();
            }




            Console.WriteLine("\"Welcome young Pilot!!\"\n" +         // \" to add quotes in console writeline
                "\n\"I am Captain Bright Noa! I welcome you aboard the WHITE BASE! Earth Federation's finest Assault Carrier SpaceShip!\"\n" +
                "\n" +
                "Captain Bright walks you through the ship, introducing you to the crew along the way.\n" +
                "Every wall of the ship is insanely clean and there seems to always be a faint humming that never\n" +
                "gets closer or further away, no matter how deep into the ship you go.\n" +
                "\n" +
                "\"This is the training room! Here we will test your combat effectiveness with our virtual GF (Gundam Fighter) machine!\n" +
                "\"You will battle adaptive AI. You may battle as many times as you need to get the feel of being in a mobile suit!\n" +
                "\"After you go through this training you will be given a mobile suit to aid us in our journey!\"\n\n" +
                "\"We have given you a PIN number for your specific use. When prompted for it use the PIN: 1979\"\n" +
                "\n\"Well what are you waiting for!? Hop to it!\n" +
                "\n" +
                "\n" +
                "You climb into the GF machine and it completely seals you inside, mimicing the cockpit of a mobile suit...");



            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            //TODOne finish good introduction
            #endregion

            #region Player Creation

            int score = 0;

            Console.WriteLine("***Please enter Pilot name!***\n");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
            Console.Clear();

            #region PIN Confimation

            bool confirm = false;
            do
            {

                Console.WriteLine("***Please enter your 4 digit PIN ***");
                string playerID = Console.ReadLine();

                switch (playerID)
                {

                    case "1979":
                        Console.WriteLine("\n\nUser identified!\n\nPlease wait while we load player information...");
                        confirm = true;
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("\nACCESS DENIED \n");
                        break;
                }
            } while (!confirm);

            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            #endregion

            Console.WriteLine($"Welcome {playerName}! You have no previous existing files in the GF network...\n" +
                $"That is okay! We will provide you with a base model \"GM\" Model mobile suit!\n\n" +
                $"After defeating 2 enemies you will be awarded the Guncannon model!\n" +
                $"After defeating 4 enemies you will be awarded the poster boy RX-78 GUNDAM!\n" +
                $"\n\n****** GM *****\nThe GM is a standard issue suit with a shield!\n" +
                $"These suits often see the first line of defense and are easily replaced\n" +
                $"Shielded units have higher block/miss chance in exchange for firepower\n" +
                $"\n***** RX-77 Guncannon *****\n" +
                $"The Guncannon abandons all defensive and instead has two shoulder mounted bazookas\n" +
                $"Similar to the RX-78 GUNDAM this one was mad as a partner prototype. While having higher\n" +
                $"firepower it still pales in comparison to the RX-78 GUNDAM.\n" +
                $"\n***** RX-78 GUNDAM *****\n" +
                $"The GUNDAM is piloted by the famous Amuro Ray and is constantly the backbone to keeping the white base defended\n" +
                $"GUNDAM is engineered with only the most quality of parts. It was in fact so difficult to make that the\n" +
                $"Earth Federation could only make one. And barely at that. GUNDAM comes with an upgraded shield, standard bazooka,\n" +
                $"and upgraded beam rifle and sabers.\n\n\n" +
                $"Good Luck out there pilot!\n\n");
            Console.Write("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Loading Simulation...\n");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine($"{playerName} Launching!");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            //Weapons beamPistol = new Weapons("Beam Pistol", 20, 20, WeaponTypes.Beam_Pistol);
            //TODO Insert mobile suit to use

            #endregion


            #region Weapon/Suit menu

            Player playerGM = new Player("GM", 10, 10, 10, 80, MSEnums.GM);
            Player playerGuncannon = new Player("Guncannon", 10, 10, 10, 80, MSEnums.Guncannon);
            Player playerRX78 = new Player("Gundam RX-78", 10, 10, 10, 80, MSEnums.RX78);

            #endregion





            #region Main Game Loop
            bool exit = false;
            do
            {
                Console.WriteLine(GetRoom());
                //TODO Select a suit to inhabit room

                EnemyMobileSuits enemy = EnemyMobileSuits.GetSuit();


                Console.WriteLine($"\n\nSuddenly a {enemy.Name} appears!\n");

                Console.WriteLine("\nMobile Suit Spotted!\n\n");
                #region Gameplay Menu Loop
                bool reload = false;
                do
                {
                    if (score >= 2)
                    {
                        playerGM = playerGuncannon;
                    }

                    if (score >= 4)
                    {
                        playerGuncannon = playerRX78;
                    }

                    Console.Write("\nWhat is your action Pilot?!\n" +
                       "A) Attack!\n" +
                       "C) Check mobile suit stats\n" +
                       "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    #region Combat Menu

                    switch (userChoice)
                    {
                        case ConsoleKey.A:

                            Console.Write("Which attack will you perform?\n\n" +
                                "W) Attack with Beam Saber\n" +
                                "A) Attack with Beam Rifle\n" +
                                "D) Attack with Bazooka\n");

                            ConsoleKey userChoice2 = Console.ReadKey(true).Key;
                            Console.Clear();

                            #region Combat
                                      

                            bool attack = false;
                            do
                            {

                                switch (userChoice2)
                                {
                                    case ConsoleKey.W:
                                        Console.WriteLine("You performed \"BEAM SABER!\"\n\n");
                                        BeamSaber.DoBattle(playerGM, enemy);

                                        if (enemy.Life <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"\nEnemy unit {enemy.Name} destroyed!\n");
                                            Console.ResetColor();

                                            Console.Write("Press any key to continue!");
                                            Console.ReadKey();
                                            Console.Clear();

                                            reload = true;

                                            score++;

                                        }
                                        attack = true;
                                        break;


                                    case ConsoleKey.A:

                                        Console.WriteLine("You fire your \"BEAM RIFLE!\"\n\n");
                                        BeamRifle.DoBattle2(playerGM, enemy);

                                        if (enemy.Life <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"\nEnemy unit {enemy.Name} destroyed!\n");
                                            Console.ResetColor();

                                            Console.Write($"Battle won! Great job {playerName}! However there is no time to rest!\n" +
                                                $"Get ready for your next sortie!\n\n" +
                                                "Press any key to continue!");
                                            Console.ReadKey();
                                            Console.Clear();

                                            reload = true;

                                            score++;

                                        }
                                        attack = true;
                                        break;

                                    case ConsoleKey.D:

                                        Console.WriteLine("You fired the \"BAZOOKA!\"\n\n");
                                        Bazooka.DoBattle3(playerGM, enemy);

                                        if (enemy.Life <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"\nEnemy unit {enemy.Name} destroyed!\n");
                                            Console.ResetColor();

                                            Console.Write($"Battle won! Great job {playerName}! However there is no time to rest!\n" +
                                                $"Get ready for your next sortie!\n\n" +
                                                "Press any key to continue!");
                                            Console.ReadKey();
                                            Console.Clear();

                                            reload = true;

                                            score++;

                                        }
                                        attack = true;
                                        break;

                                    default:
                                        Console.WriteLine("Input not recognized. Please try again.");
                                        attack = true;
                                        break;
                                }
                            } while (!attack);
                            break;
                           
                            #endregion

                        case ConsoleKey.C:
                            //TODO Check suit stats
                            Console.WriteLine("Checking stats...");
                            System.Threading.Thread.Sleep(500);
                            Console.Clear();
                            Console.WriteLine(playerGM);
                            Console.WriteLine();
                            Console.WriteLine(enemy);
                            Console.WriteLine();
                            Console.WriteLine($"Enemies defeated: {score}");
                            break;


                        case ConsoleKey.X:
                            Console.WriteLine("Thank your for training today! Results posted below:\n\n");
                            exit = true;

                            break;

                        default:
                            Console.WriteLine("Input not recognized. Please try again.");
                            exit = false;
                            break;
                    }//end switch

                    //TODO Check player life
                    if (playerGM.Life <= 0)
                    {
                        Console.WriteLine("Mission Failed\a");
                        exit = true;
                    }
                    #endregion
                } while (!reload && !exit);
                #endregion

            } while (!exit);//When true will cause the outer loop to full exit.

            //Show enemies defeated
            Console.WriteLine("You defeated " + score + " enemies" +
                (score == 1 ? "." : "s."));

            #endregion
            Signatures.Footer();
        }//end main    

        #region Rooms


        private static string GetRoom()
        {
            string[] rooms =
            {

                "You look from your mobile suit's monitor and see the black hue of space surrounding you.\n" +
                "You float in Zero-G staring at the stars, Earth glimmering from the corner of your eyes.\n" +
                "From afar you see a dashing among the stars, similar almost to a comet in passing... ",

                "Your suit lands... You look around and are surrounded by wasteland. You seem to have landed\n" +
                "in an abondoned city in the desert. Its very obvious that this was a battlefield long ago.\n" +
                "From the west you see dust and sand barreling towards you from behind a sand dune.\n" +
                "Looking harder you see a slight glint under all the debris...",

                "You emerge from a large river... looking around you see nothing but jungle. Trees as large\n" +
                "as your massive mobile suit. You can still see the water running down your camera through your moniter\n" +
                "turning to your right you see the treeline shifting. Moving around you quickly. \n" +
                "Between the trees you make out the dark outline of something...",

                "You hover over the ever expanse of the Pacific Ocean. Looking in all directions you see\n" +
                "nothing but the ever expanse of the Sea. Expecting and enemy you look in all directions\n" +
                "Finding nothing you dive into the sea.\n" +
                "As soon as the water settles you see two glowing eyes in front of you..."

            };

            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }
        #endregion

    }//end class
}//end namespace