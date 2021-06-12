using System;

namespace CSharpPlayersGuide.Lvl10
{
    public class Inventory
    {
        public static void Buying()
        {
            Console.WriteLine("The following items are available: ");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the prices of?");
            int selection = Convert.ToInt32(Console.ReadLine());

            string response;
            response = selection switch
            {
                1 => "Ropes cost 10 gold.",
                2 => "Torches cost 15 gold.",
                3 => "Climbing Equipment costs 25 gold.",
                4 => "Clean Water costs 1 gold.",
                5 => "Machetes cost 20 gold.",
                6 => "Canoes cost 200 gold.",
                7 => "Food Supplies cost 1 gold.",
                _ => "I'm sorry, that isn't an option."
            };
            
            Console.WriteLine(response);
            
        }
    }
}