using System;

namespace CSharpPlayersGuide.Lvl9
{
    public class Watchtower
    {
        public static void Direction()
        {
            Console.WriteLine("What is the x value?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the y value?");
            int y = Convert.ToInt32(Console.ReadLine());

            string direction = "";
            
            if (x < 0 && y > 0)
            {
                direction = "northwest";
            } else if (x == 0 && y > 0)
            {
                direction = "north";
            } else if (x > 0 && y > 0)
            {
                direction = "northeast";
            } else if (x < 0 && y == 0)
            {
                direction = "west";
            }
            else if (x == 0 && y == 0)
            {
                direction = "!";
            } else if (x > 0 && y == 0)
            {
                direction = "east";
            } else if (x < 0 && y < 0)
            {
                direction = "southwest";
            } else if (x == 0 && y < 0)
            {
                direction = "south";
            } else if (x > 0 && y < 0)
            {
                direction = "southeast";
            }

            if (direction != "!")
            {
                Console.WriteLine($"The enemy is to the {direction}!");
            }
            else
            {
                Console.WriteLine("The enemy is here!");
            }
        }
    }
}