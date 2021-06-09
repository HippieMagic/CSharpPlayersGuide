using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Lvl8
{
    class TheDefenseOfConsolas
    {
        public static void Defense()
        {
            // Change the title
            Console.Title = "The Defense of Consolas";

            // get the coordinates
            Console.Write("Target Row? ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Deploy To: ");

            // Calculate where to position
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            // Change the color back.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
