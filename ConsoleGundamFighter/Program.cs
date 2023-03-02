﻿using SignatureLibrary;
using System.Media;
using TextToAsciiArt;
using static System.Console;

namespace ConsoleGundamFighter
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
                "\"You will go through three battles against superior adaptaple AI\n" +
                "\"After you go through this training you will be given a mobile suit to aid us our journey!\"\n" +
                "\n\"Well what are you waiting for!? Hop to it!\n" +
                "\n" +
                "\n" +
                "You climb into the GF machine and it completely seals you inside, mimicing the cockpit of a mobile suit...");



            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            //TODO finish good introduction
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            //TODO Weapon creation

            //TODO Player Object creation

            #endregion

            #region Main Game Loop
            bool exit = false;
            do
            {
                Console.WriteLine(GetRoom());
                //TODO Select a random monster to inhabit room
                Console.WriteLine("\nMobile Suit Spotted!");
                #region Gameplay Menu Loop
                bool reload = false;
                do
                {
                    //TODO Gameplay Menu
                    #region Menu

                    //TODO select mobile suit menu

                    Console.Write("\nWhat is your action Pilot?!\n" +
                       "W) Attack with Beam Saber\n" +
                       "A) Attack with Beam Rifle\n" +
                       "D) Attack with Bazooka\n" +
                       //How will "search" affect this function? how to make so that sometimes can just straight up attack instead of having to search.

                       "T) Try to speak to enemy\n" +//TODO change "enemy" to {enemy name}
                       "C) Check mobile suit stats\n" +
                       "S) Scan enemy\n" + //make search function to decide who will attack. make variable to up "sense" to have a higher chance to spot enemy first
                       "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.W:
                            //TODO Beam saber
                            Console.WriteLine("Attack with Beam Saber!");
                            break;

                        case ConsoleKey.A:
                            //TODO Beam rifle
                            Console.WriteLine("Attack with Beam Rifle");
                            break;

                        case ConsoleKey.D:
                            //TODO Bazooka
                            Console.WriteLine("Attack with Bazooka");
                            break;

                        case ConsoleKey.T:
                            //TODO Dialogue
                            Console.WriteLine("Why?!");//Dialogue option
                            break;

                        case ConsoleKey.C:
                            //TODO Check stats for available attacks
                            Console.WriteLine("Checking stats...");
                            break;

                        case ConsoleKey.S:
                            //Search for enemy
                            Console.WriteLine("Searching...");
                            break;
                        //Possible only have to search after choosing dialogue option!

                        case ConsoleKey.X:
                            Console.WriteLine("Thank your for training today! Results posted below:\n\n");
                            exit = true;

                            break;
                        default:
                            break;
                    }//end switch
                    #endregion


                    //TODO Check player life


                } while (!reload && !exit);
                #endregion

            } while (!exit);//When true will cause the outer loop to full exit.

            //Show enemies defeated
            Console.WriteLine("You defeated " + score + " enemies" +
                (score == 1 ? "." : "s."));

            #endregion
            Signatures.Footer();
        }//end main    

        private static string GetRoom()
        {
            string[] rooms =
            {
                
                "You look from your mobile suit's monitor and see the black hue of space surrounding you.\n" +
                "You float in Zero-G staring at the stars, Earth glimmering from the corner of your eyes.\n" +
                "From afar you see a dashing among the stars, similar almost to a comet in passing... ",

                
            };

            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }


    }//end class
}//end namespace