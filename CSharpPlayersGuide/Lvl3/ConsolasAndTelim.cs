using System;
using System.IO;

namespace CSharpPlayersGuide.Lvl3
{
    public class ConsolasAndTelim
    {
        public static void Bread()
        {
            string name;
            // write the prompts for the user.
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            name = Console.ReadLine(); // get input from the user and store it in the name variable.
            /* random multiline comment
                Just because I can.
            */
            Console.WriteLine(name + /* never thought about doing it this way */ " got bread.");
        }
    }
}