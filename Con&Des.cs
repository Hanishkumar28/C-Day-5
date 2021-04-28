using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Person
    {
        public string Name;
        public Person(string _name)
        {
            Name = _name;
        }
        public override string ToString()
        {
            return "I am "+Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
        static void Main()
        {
            int n = 3;
            Person[] per = new Person[n];
            for (int i=0; i<n; i++)
            {
                Console.Write("Enter the Person Name : ");
                per[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(per[i].ToString());
            }
        }
    }
}
