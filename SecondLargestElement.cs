using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class SecondLargest
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the Elements of the array: ");
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            
            Console.WriteLine("The Second Largest element is : "+arr[(arr.Length) - 2]);
        }
    }
}
