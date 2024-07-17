using System;

namespace CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            Time t2 = new Time(1, 19);

            Time t3 = new Time(3, 50, 23);
            Console.WriteLine(t3);
            Console.WriteLine(t3.ToString());
            t3.WriteTime();
            t3.WriteTime2(t3);  // Instance method
            t2.WriteTime2(t3);
            t1.WriteTime2(t3);  // Best if passing a time to another
            Time.WriteTime(t3);
        }
    }
}
