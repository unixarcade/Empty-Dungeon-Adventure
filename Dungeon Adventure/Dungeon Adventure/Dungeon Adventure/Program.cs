using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Speech.Synthesis;

// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{


    
        class Program
        {


            static void myexit()
            {
                Environment.Exit(0);
            }

            static string myYesNo()
            {
                Console.WriteLine(" Yes or No ?");
                string yn = Console.ReadLine();
                yn = yn.ToUpper();
                if (yn=="YES" || yn == "Y" || yn == "YE")
                {
                    yn = "YES";
                }
                else
                {
                    yn = "NO";
                }
               
                return yn;
            }
            static void Main(string[] args)
            {
               






                string name, yn, adventure;

                #region Game Startup
                TextScreen.MyColorTextScreen(); // Colored Screen
                // TextScreen.myTextScreen(); // BW Graphic
                Console.ForegroundColor = ConsoleColor.White;

                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    synth.Speak("Mindscape Dungeon Adventure"); // Spoken Title
                }



                Console.Title = " Mindscape Dungeon Adventure";
                Console.WriteLine(" Mindscape Dungeon Adventure");
                Console.WriteLine();
                Console.WriteLine(" Welcome Adventurer ");
                Console.WriteLine();

                #endregion



                Console.WriteLine(" What is your name? ");
                Console.WriteLine();
                name = Console.ReadLine();
                Console.WriteLine();

                do
                {
                    Console.Clear();
                Console.WriteLine(" Would you like to go on an adventure " + name);
               
                yn = myYesNo();

               
                if (yn == ("NO") || yn == "N")
                {
                    myexit();
                }

                if (yn == ("YES") || yn == ("Y"))
                {
                    Console.WriteLine(" Then let the adventure begin ");
                    Console.WriteLine(" Do you want to go to the Forests, Mountains, Plains, Islands, Swamps? ");
                    adventure = Console.ReadLine();
                    adventure = adventure.ToUpper();

                    string welcometo = "Welcome to the ";

                    #region Adventure 
                    switch (adventure)
                    {
                        case "FORESTS":

                            Console.WriteLine(welcometo + " Forests");

                            break;
                        case "MOUNTAINS":

                            Console.WriteLine(welcometo + " Mountains");


                            break;
                        case "PLAINS":
                            Console.WriteLine(welcometo + " Plains");

                            break;
                        case "ISLANDS":
                            myexit();

                            Console.WriteLine(welcometo + " Islands");
                            break;
                        case "SWAMPS":
                            Console.WriteLine(welcometo + " Swamps");
                            break;

                        default:
                            Console.WriteLine("I did not hear you correctly. Where did you want to go?");
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Come again soon.");





                }

                Console.ReadKey();

                    #endregion









                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            }
        }
    }

