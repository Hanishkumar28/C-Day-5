using System;
using System.Collections.Generic;
using System.Text;
namespace Day5
{
    class DateTime
    {
        static void Main()
        {
            System.DateTime obj = System.DateTime.Now;
            Console.WriteLine("Year = " + obj.Year);
            Console.WriteLine("Month = "+String.Format("{0:MMMM}",obj));
            Console.WriteLine("Day = " + obj.Day);
            Console.WriteLine("Hour = " + obj.Hour);
            Console.WriteLine("Minute = " + obj.Minute);
            Console.WriteLine("Second = " + obj.Second);
            Console.WriteLine("Millisecond = " + obj.Millisecond);
        }
    }
}
