using System;

namespace CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time time = new Time();
            Console.WriteLine(time.hour);
            Console.WriteLine(time.minute);
            Console.WriteLine(time.second);
        }

    }
}
