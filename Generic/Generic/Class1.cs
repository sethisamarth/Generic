using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Class1
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            Class1.toPrint<int>( intArray);
            Class1.toPrint(doubleArray);
            Class1.toPrint(charArray);
        }
    }
}
