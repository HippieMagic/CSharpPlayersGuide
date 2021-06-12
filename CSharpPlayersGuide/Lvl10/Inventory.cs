using System;

namespace CSharpPlayersGuide.Lvl10
{
    public class Inventory
    {
        public static void Buying()
        {
            MenuText();
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
        
        public static void Discount()
        {
            MenuText();
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            bool discount = Console.ReadLine().ToLower() == "nick";
            string response;
            double cost;
            switch (selection)
            {
                case 1:
                    cost = discount ? 10 * 0.50 : 10;
                    response = $"Ropes cost {cost} gold.";
                    break;
                case 2:
                    cost = discount ? 15 * 0.50 : 15;
                    response = $"Torches cost {cost} gold.";
                    break;
                case 3:
                    cost = discount ? 25 * 0.50 : 25;
                    response = $"Climbing Equipment costs {cost} gold.";
                    break;
                case 4:
                    cost = discount ? 1 * 0.50 : 1;
                    response = $"Clean Water costs {cost} gold.";
                    break;
                case 5:
                    cost = discount ? 20 * 0.50 : 20;
                    response = $"Machetes cost {cost} gold.";
                    break;
                case 6:
                    cost = discount ? 200 * 0.50 : 200;
                    response = $"Canoes cost {cost} gold.";
                    break;
                case 7:
                    cost = discount ? 1 * 0.50 : 1;
                    response = $"Food Supplies cost {cost} gold.";
                    break;
                default:
                    response = "I'm sorry, that isn't an option.";
                    break;
            }

            Console.WriteLine(response);
            
        }

        private static void MenuText()
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
        }
    }
}