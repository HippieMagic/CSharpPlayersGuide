using System;

namespace CSharpPlayersGuide.Lvl7
{
    public class TheTriangleFarmer
    {
        public static void Area()
        {
            Console.WriteLine("What is your base?");
            Double triangleBase = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is your height?");
            Double triangleHeight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("The area of your triangle is: {0}", triangleBase * triangleHeight / 2);
        }
    }
}