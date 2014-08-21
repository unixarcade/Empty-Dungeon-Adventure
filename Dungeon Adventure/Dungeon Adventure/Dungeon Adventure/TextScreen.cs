using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Adventure
{
    public static class TextScreen
    {

        public static void myTextScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("             .:::::::::..      "); // line one 
            Console.WriteLine("       ..:::aad8888888baa:::.."); // line two
            Console.WriteLine("     .::::d:?88888888888?::8b::::."); // line three
            Console.WriteLine("   .:::d8888:?88888888??a888888b:::."); // line four
            Console.WriteLine("  .:::d8888888a8888888aa8888888888b:::."); // line five
            Console.WriteLine(" ::::dP::::::::88888888888::::::::Yb::::"); // line six 
            Console.WriteLine(" ::::dP:::::::::Y888888888P:::::::::Yb::::"); // line seven
            Console.WriteLine(" ::::d8:::::::::::Y8888888P:::::::::::8b::::"); // line eight
            Console.WriteLine(" .::::88::::::::::::Y88888P::::::::::::88::::."); // line nine
            Console.WriteLine(" :::::Y8baaaaaaaaaa88P:T:Y88aaaaaaaaaad8P:::::");  // line ten
            Console.WriteLine(" :::::::Y88888888888P::|::Y88888888888P:::::::"); // line eleven
            Console.WriteLine(" ::::::::::::::::888:::|:::888::::::::::::::::"); // line twelve
            Console.WriteLine(" `:::::::::::::::8888888888888b::::::::::::::'"); // line thirteen
            Console.WriteLine("  :::::::::::::::88888888888888::::::::::::::"); // line fourteen
            Console.WriteLine("   :::::::::::::d88888888888888:::::::::::::  "); // line fifteen
            Console.WriteLine("   ::::::::::::88::88::88:::88::::::::::::    "); // line sixteen
            Console.WriteLine("     `::::::::::88::88::88:::88::::::::::'    "); // line seventeen
            Console.WriteLine("       `::::::::88::88::P::::88::::::::'      "); // line eighteen
            Console.WriteLine("         `::::::88::88:::::::88::::::'       "); // line nineteen
            Console.WriteLine("            ``:::::::::::::::::::''       "); // line twenty
            Console.WriteLine("                 ``:::::::::''           "); // line twentyone




            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("Add your Visual and Text for this Screen");



        }

        public static void MyColorTextScreen()
        {

            // Just incase you want color ASCII Graphics

            ConsoleColor printblack = ConsoleColor.Black;
            ConsoleColor printwhite = ConsoleColor.White;
            ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
            ConsoleColor printlightgrey = ConsoleColor.Gray;




            //Console.BackgroundColor = ConsoleColor.DarkGray;

            // line one
            Console.ForegroundColor = ConsoleColor.Black;

            Console.ForegroundColor = printblack;
            Console.Write("             ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::::::::..");
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.WriteLine();

            // line two
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("aad8888888baa");
            Console.ForegroundColor = printwhite;
            Console.Write(":::..");
            Console.WriteLine();

            // line three
            Console.Write("     ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("d");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("?88888888888?");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::.");
            Console.WriteLine();

            // line four
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("d8888");
            Console.ForegroundColor = printwhite;
            Console.Write(":?");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("88888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("??a");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("888888b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.WriteLine();

            //line five

            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("d8888888a8888888aa8888888888b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.WriteLine();

            // line six

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("dP");
            Console.ForegroundColor = printblack;
            Console.Write("::::::::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("88888888888");
            Console.ForegroundColor = printblack;
            Console.Write("::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Yb");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.WriteLine();

            //line seven

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("dP");
            Console.ForegroundColor = printblack;
            Console.Write(":::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("888888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write(":::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Yb");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.WriteLine();

            //line eight

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("d8");
            Console.ForegroundColor = printblack;
            Console.Write(":::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write(":::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.WriteLine();

            // line nine

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("88");
            Console.ForegroundColor = printblack;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write("::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("88");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.WriteLine();

            // line ten

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y8");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("baaaaaaaaaa88");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write(":");
            Console.ForegroundColor = printlightgrey;
            Console.Write("T");
            Console.ForegroundColor = printblack;
            Console.Write(":");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("88aaaaaaaaaad8");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y8");

            Console.ForegroundColor = printwhite;
            Console.Write("::::.");
            Console.WriteLine();

            // line eleven

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printlightgrey;
            Console.Write("888888888");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("|");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("Y");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printlightgrey;
            Console.Write("888888888");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printlightgrey;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.WriteLine();

            // line twelve

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("88");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write(":::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("|");
            Console.ForegroundColor = printblack;
            Console.Write(":::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("888");

            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::");
            Console.WriteLine();


            // line thirteen

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("888888888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::'");
            Console.WriteLine();

            // line fourteen

            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("88888888888888");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::'");
            Console.WriteLine();

            // line fifteen

            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::");
            Console.ForegroundColor = printlightgrey;
            Console.Write("d");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8888888888888");
            Console.ForegroundColor = printlightgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();

            // line sixteen

            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write(":::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();

            // line seventeen


            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::::::::");

            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printblack;
            Console.Write("::");
            Console.ForegroundColor = printwhite;
            Console.Write("8");
            Console.ForegroundColor = printdarkgrey;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();


            // line eighteen
            Console.ForegroundColor = printblack;
            Console.Write("         ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::::::::::::::::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.WriteLine();

            // line nineteen
            Console.ForegroundColor = printblack;
            Console.Write("            ");
            Console.ForegroundColor = printwhite;
            Console.Write("``:::::::::::::::::::''");
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.WriteLine();

            // line twenty

            Console.ForegroundColor = printblack;
            Console.Write("                 ");
            Console.ForegroundColor = printwhite;
            Console.Write("``:::::::::''");
            Console.ForegroundColor = printblack;
            Console.Write("           ");
            Console.WriteLine();

            // spacer

            Console.WriteLine();








        }
    }
}
