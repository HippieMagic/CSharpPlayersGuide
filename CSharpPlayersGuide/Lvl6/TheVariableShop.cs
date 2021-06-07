using System;

namespace CSharpPlayersGuide.Lvl6
{
    public class TheVariableShop
    {
        public static void Variables()
        {
            string helloWorld = "Hello World";
            helloWorld = "One";
            char letter = 'a';
            letter = '2';
            
            byte byteVar = 1;
            byteVar = 3;
            short shortVar = 2;
            shortVar = 4;
            int intVar = 3;
            intVar = 5;
            long longVar = 4;
            longVar = 6;
            sbyte sbyteVar = 5;
            sbyteVar = 7;
            ushort ushortVar = 6;
            ushortVar = 8;
            uint uintVar = 7;
            uintVar = 9;
            ulong ulongVar = 8;
            ulongVar = 10;

            float floatVar = 1.1f;
            floatVar = 11.11f;
            double doubleVar = 2.2;
            doubleVar = 12.12;
            decimal decimalVar = 3.3m;
            decimalVar = 13.13m;

            bool boolVar = true;
            boolVar = false;
            
            Console.WriteLine(helloWorld);
            Console.WriteLine(letter);
            Console.WriteLine(byteVar);
            Console.WriteLine(shortVar);
            Console.WriteLine(intVar);
            Console.WriteLine(longVar);
            Console.WriteLine(sbyteVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(ulongVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(decimalVar);
            Console.WriteLine(boolVar);
        }
    }
}