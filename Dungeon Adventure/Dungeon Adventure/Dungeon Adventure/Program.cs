using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{


    //public partial class Form1 : Form
    //{
    //    public Form1()
    //    {
    //        InitializeComponent();

    //    }

    //    private void InitializeComponent()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    private void Form1_Load(object sender, EventArgs e)
    //    {

    //    }
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
                if (yn == "y" || yn == "ye")
                {
                    yn = "YES";
                }
                else
                {
                    yn = "NO";
                }
                yn = yn.ToUpper();
                return yn;
            }
            static void Main(string[] args)
            {
                //// Form Source Code
                //// This Code Should really be in a Class
                //Form f = new Form();

                //f.Text = "  Empty Dungeon Adventure  ";
                //f.Name = "Empty Dungeon Adventure";
                //Label nameLabel = new Label();
                //nameLabel.AutoSize = true;
                //nameLabel.Text = "Empty Dungeon Adventure";
                //nameLabel.Top = 100;
                //nameLabel.Left = 80;
                //f.Controls.Add(nameLabel);
                //f.ShowDialog();





                //// End of Form Code

               // Form1 f1 = new Form1();
               // f1.ShowDialog();






                string name, yn, adventure;
                Console.Title = " Mindscape Dungeon Adventure";
                Console.WriteLine(" Welcome Adventurer ");
                Console.WriteLine(" What is your name? ");
                name = Console.ReadLine();
                Console.WriteLine(" Would you like to go on an adventure " + name);
               
                yn = myYesNo();
                if (yn == ("YES") || yn == ("Y"))
                {
                    Console.WriteLine(" Then let the adventure begin ");
                    Console.WriteLine(" Do you want to go to the Forests, Mountains, Plains, Islands, Swamps? ");
                    adventure = Console.ReadLine();
                    adventure = adventure.ToUpper();

                    string welcometo = "Welcome to the ";
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













            }
        }
    }

