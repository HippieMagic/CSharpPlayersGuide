using System;

namespace CSharpPlayersGuide.Lvl7
{
    public class FourSisters
    {
        public static void AndTheDuckbear()
        {
            Console.WriteLine("How many chocolate eggs were gathered today?");
            string answer = Console.ReadLine();
            int eggCount = Convert.ToInt32(answer);

            int eggsPerSister = eggCount / 4;
            Console.WriteLine("Each sister gets {0} eggs.", eggsPerSister);

            int eggsForDuckbear = eggCount % 4;
            Console.WriteLine("The duckbear gets {0} eggs.", eggsForDuckbear);
        }
    }
}