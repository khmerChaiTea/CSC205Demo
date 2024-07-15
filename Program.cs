using System;

namespace ThinkSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Call methods WriteArray and RandomArray by giving 10 as the parameter/arguement
            WriteArray(RandomArray(10));
        }

        public static int[] RandomArray(int size)
        {
            Random random = new Random();
            // Set array size to given "size" from the passing arguement as parameter
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)  // array.Length should be same as size
            {
                array[i] = random.Next(0, 100);     // generate up to 100 random number
            }
            return array;   // return the array
        }

        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Print the output for each iteration with a given parameter
                Console.WriteLine(array[i]);
            }
        }
    }
}

