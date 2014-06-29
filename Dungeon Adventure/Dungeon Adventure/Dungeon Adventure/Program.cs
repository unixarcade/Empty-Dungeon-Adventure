using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, yn, adventure;
            Console.Title =" Mindscape Dungeon Adventure";
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Would you like to go on an adventure" + name);
            Console.WriteLine("Yes or No");
            yn = Console.ReadLine();
           yn = yn.ToUpper();
           if (yn == "YES")
           {
               Console.WriteLine("Then let the adventure begin");
               Console.WriteLine("Do you want to go to the Forest, Mountain, Plains, Island, Swamp? ");
               adventure = Console.ReadLine();
               adventure = adventure.ToUpper();

              string welcometo = "Welcome to the ";
               switch (adventure)
               {
                   case "Forest":
                       Console.WriteLine(welcometo +" Forest");

                      break;
                  case "Mountain":
                      Console.WriteLine( welcometo + " Mountains");
                      
                      
                      break;
                   case "Plains":
                      Console.WriteLine(welcometo + " Plains");
                       
                       break;
                  case "Islands":
                       Console.WriteLine(welcometo + " Islands");
                     break;
                   case "Swamp":
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
