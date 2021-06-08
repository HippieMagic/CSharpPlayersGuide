using System;

namespace CSharpPlayersGuide.Lvl7
{
    class TheDominionOfKings
    {
        public static void Holdings()
        {
            // prompt the user for the quantity of each.
            // maybe add input validation later.

            Console.WriteLine("Please enter the number of provinces: ");
            int provinces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of duchies: ");
            int duchies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of estates: ");
            int estates = Convert.ToInt32(Console.ReadLine());

            //provinces = 6, duchies = 3, and estates = 1.

            int pointTotal = provinces * 6;
            pointTotal += duchies * 3;
            pointTotal += estates;

            Console.WriteLine("Your point total is: {0}", pointTotal);
        }
    }
}
