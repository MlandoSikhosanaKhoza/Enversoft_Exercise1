﻿using System;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };
            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
            int[] list3 = new int[] { };
            Console.WriteLine(string.Join(" ", list3));
            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            int[] list4 = new int[] { };
            Console.WriteLine(string.Join(" ", list4));
            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"
            int[] list5 = new int[] { };
            Console.WriteLine(string.Join(" ", list5));
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}