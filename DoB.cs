using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class DoB
    {
        static void Main()
        {
            System.DateTime dob = new System.DateTime(1999,02,28);
            System.DateTime cdt = System.DateTime.Now;
            int Day = cdt.Day - dob.Day;
            int Month = cdt.Month - dob.Month;
            int Year = cdt.Year - dob.Year;
            Console.WriteLine(String.Format("Age: " + Year + " Year(s) " + Month + " Month(s) " + Day + " Day(s) "));
        }
    }
}
