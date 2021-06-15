using System;

namespace CSharpPlayersGuide.Lvl11
{
    public class ThePrototype
    {
        public static void Proto()
        {
            int user1Number = -1;

            while (user1Number < 0 || user1Number > 100)
            {
                Console.WriteLine("User 1, enter a number between 0 and 100: ");
                string user1Response = Console.ReadLine();
                user1Number = Convert.ToInt32(user1Response);
            }

            Console.Clear();

            Console.WriteLine("User 2, guess the number.");
            int user2Number = -1;

            do
            {
                string user2Response = Console.ReadLine();
                user2Number = Convert.ToInt32(user2Response);

                if (user2Number > user1Number)
                {
                    Console.WriteLine($"{user2Number} is too high.");
                }
                else if (user2Number < user1Number)
                {
                    Console.WriteLine($"{user2Number} is too low.");
                }
                else
                {
                    Console.WriteLine("You guessed the number!");
                }
            } while (user1Number != user2Number);
        }
    }
}