using System;

namespace CSharpPlayersGuide.Lvl12
{
    public static class TheReplicator
    {
        public static void DTo()
        {
            int[] originalArray = new int[5];
            
            Console.WriteLine("Please enter 5 numbers:");

            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] copiedArray = new int[5];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }
            
            Console.WriteLine("The original array is: ");
            foreach (var t in originalArray)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("The new array contains: ");
            foreach (var t in copiedArray)
            {
                Console.WriteLine(t);
            }
        }
    }
}