using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205
{
    public class Time
    {
        public int hour, minute;
        public double second;

        // Here is an example for the Time Class:
        // This code below is the constructor (default)
        public Time()
        {
            // We drop 'this.'
            hour = 1;
            minute = 2;
            second = 3.0;
        }

        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = 1.0;
        }

        public Time(int hour, int minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
        {
            return this.hour + ":" + this.minute + ":" + this.second;
        }

        public void WriteTime()
        {
            Console.WriteLine(this.hour + ":" + this.minute + ":" + this.second);
        }

        public void WriteTime2(Time t)
        {
            Console.WriteLine(this.hour + ":" + this.minute + ":" + this.second);
        }

        public static void WriteTime(Time t)
        {
            Console.WriteLine(t.hour + ":" + t.minute + ":" + t.second);
        }
    }
}