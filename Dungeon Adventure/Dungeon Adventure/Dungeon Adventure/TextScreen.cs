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
            Console.WriteLine("             .:::::::::..      ");
            Console.WriteLine("       ..:::aad8888888baa:::..");
            Console.WriteLine("     .::::d:?88888888888?::8b::::.");
            Console.WriteLine("   .:::d8888:?88888888??a888888b:::.");
            Console.WriteLine("  .:::d8888888a8888888aa8888888888b:::.");
            Console.WriteLine(" ::::dP::::::::88888888888::::::::Yb::::");
            Console.WriteLine(" ::::dP:::::::::Y888888888P:::::::::Yb::::");
            Console.WriteLine(" ::::d8:::::::::::Y8888888P:::::::::::8b::::");
            Console.WriteLine(" .::::88::::::::::::Y88888P::::::::::::88::::.");
            Console.WriteLine(" :::::Y8baaaaaaaaaa88P:T:Y88aaaaaaaaaad8P:::::");
            Console.WriteLine(" :::::::Y88888888888P::|::Y88888888888P:::::::");
            Console.WriteLine(" ::::::::::::::::888:::|:::888::::::::::::::::");
            Console.WriteLine(" `:::::::::::::::8888888888888b::::::::::::::'");
            Console.WriteLine("  :::::::::::::::88888888888888::::::::::::::");
            Console.WriteLine("   :::::::::::::d88888888888888:::::::::::::  ");
            Console.WriteLine("   ::::::::::::88::88::88:::88::::::::::::    ");
            Console.WriteLine("     `::::::::::88::88::88:::88::::::::::'    ");
            Console.WriteLine("       `::::::::88::88::P::::88::::::::'      ");
            Console.WriteLine("         `::::::88::88:::::::88::::::'       ");
            Console.WriteLine("            ``:::::::::::::::::::''       ");
            Console.WriteLine("                 ``:::::::::''           ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("Add your Visual and Text for this Screen");



        }
    }
}
