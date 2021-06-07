using System;

namespace CSharpPlayersGuide.Lvl4
{
    public class TheThingNamer3000
    {
        public static void ThingNamer()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            // Get the name of the item in question.
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); // Get an adjective describing it
            string c = "of Doom";
            string d = "3000";
            Console.WriteLine("The " + b /* adj */ + " " + a /* item */ + " " + c /* of doom */ + " " + d /* 3000 */ + "!");
        }
    }
}