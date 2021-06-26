using System;

namespace CSharpPlayersGuide.Lvl12
{
    public class TheLaws
    {
        public static void Freach()
        {
            int[] minNumArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = int.MaxValue; // Start higher than anything in the array.
            foreach (var number in minNumArray)
            {
                if (number < currentMinimum)
                    currentMinimum = number;
            }
            Console.WriteLine(currentMinimum);
            
            int[] averageArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            foreach (var number in averageArray)
                total += number;

            float average = (float)total / averageArray.Length; Console.WriteLine(average);
            
        }
    }
}