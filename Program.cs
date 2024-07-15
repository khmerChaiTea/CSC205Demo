using System;
namespace ThinkSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] scores = RandomArray(30);
            // Print output of n(30) amount of random number from method RandomArray
            WriteArray(scores);
            int[] counts = new int[100];
            for (int i = 0; i < scores.Length; i++)
            {
                /* 
                // look at index if the value equal index count it
                int index = scores[i];
                // Imcrement count of value in array
                counts[index]++;
                */
                counts[scores[i]]++;
            }
            // Output the count of number in the array
            WriteArray(counts);
        }
        public static int[] RandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }
        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
