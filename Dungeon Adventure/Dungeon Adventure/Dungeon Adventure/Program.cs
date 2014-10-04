using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Speech.Synthesis;
using System.Threading;

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



                #region Vars

                string name, adventure;
                int managoal = 0;
                Int32 answerchoice;
                string mychoice;
                string welcometo = " Welcome to the ";
                string[][] thepowerof = new string[][]{
                            new string[]{" The Power of "},
                            new string[]{" Green ", " Red ", " White ", " Blue ", " Black "},
                            new string[]{" mana infuses you. "}             
                                                      };
                string manasent = " mana infuses you. ";
                string[] mycolor = { " Green ", " Red ", " White ", " Blue ", " Black " };
                string[] status = { " Initiate ", " Acolyte ", " Adept ", " Master ", " Avatar ", " Planes Walker" };
                string yn;
                string mycode;



                //color
                ConsoleColor printblack = ConsoleColor.Black;
                ConsoleColor printwhite = ConsoleColor.White;
                ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
                ConsoleColor printlightgrey = ConsoleColor.Gray;
                ConsoleColor printdarkblue = ConsoleColor.DarkBlue;
                ConsoleColor printlightblue = ConsoleColor.Blue;
                ConsoleColor printlightred = ConsoleColor.Red;
                ConsoleColor printdarkred = ConsoleColor.DarkRed;
                ConsoleColor printdarkyellow = ConsoleColor.DarkYellow;
                ConsoleColor printlightyellow = ConsoleColor.Yellow;
                ConsoleColor printlightgreen = ConsoleColor.Green;
                ConsoleColor printdarkgreen = ConsoleColor.DarkGreen;
                #endregion



               

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
                    GameHelpers.RefreshConsole();
                Console.WriteLine(" Would you like to go on an adventure " + name);
               
                yn = myYesNo();

               
                if (yn == ("NO") || yn == "N")
                {
                    myexit();
                }

                if (yn == ("YES") || yn == ("Y"))
                {
                    Console.WriteLine(" Then let the adventure begin ");

                    Console.WriteLine(" Then let the adventure begin ");
                    Console.Write(" Do you want to go to the ");
                    Console.ForegroundColor = printlightgreen;
                    Console.Write(" Forests, ");
                    Console.ForegroundColor = printlightred;
                    Console.Write(" Mountains, ");
                    Console.ForegroundColor = printlightyellow;
                    Console.Write(" Plains, ");
                    Console.ForegroundColor = printlightblue;
                    Console.Write(" Islands, ");
                    Console.ForegroundColor = printlightgrey;
                    Console.Write(" Swamps?  \n");
                    
                    
                    
                    
                    adventure = Console.ReadLine();
                    adventure = adventure.ToUpper();

                    

                    #region Adventure 
                    switch (adventure)
                    {
                        case "FORESTS":

                            Console.WriteLine(welcometo + " Forests");

                            #region Adventure Choice One
                            // Adventure Choice One

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                            mycode = myYesNo();
                            if (mycode == "YES")
                            {


                                //managoal++;
                                managoal = 2;


                                GameHelpers.SpaceandClean();
                               

                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();


                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                            # endregion

                            #region Adventure Choice Two
                            // Adventure Choice Two

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 2)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;



                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion



                            #region Adventure Choice Three
                            // Adventure Choice Three

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 3)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;



                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion




                            #region Adventure Choice Four
                            // Adventure Choice Four

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 4)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;


                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion



                            #region Adventure Choice Five
                            // Adventure Choice Five

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 5)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;


                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion






                            #region Adventure Choice Six
                            // Adventure Choice Six

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 6)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;



                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion

                            #region Adventure Choice Seven
                            // Adventure Choice Seven

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 7)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;


                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion



                            #region Adventure Choice Eight
                            // Adventure Choice Eight

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 8)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;


                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion




                            #region Adventure Choice Nine
                            // Adventure Choice Nine

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                            if (managoal == 9)
                            {
                                mycode = myYesNo();
                                if (mycode == "YES")
                                {
                                    managoal++;



                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();


                                }
                                else
                                {

                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                    break;
                                }
                            }
                            # endregion



                            #region Adventure Choice Ten
                            // Adventure Choice Ten
                            if (managoal == 10)
                            {
                                GameHelpers.SpaceandClean();
                                Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                                mycode = myYesNo();

                                if (mycode == "YES")
                                {




                                    GameHelpers.SpaceandClean();
                                    Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);

                                    Console.ReadKey();
                                }
                                break;


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }





                            # endregion
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








                GameHelpers.RefreshConsole();
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            }
        }
    }

