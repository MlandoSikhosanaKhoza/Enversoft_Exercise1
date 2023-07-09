using System;
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

            #region A - Common Elements

            int[] list3 = list1.Where(l1 => list2.Any(l2 => l1 == l2)).Select(l3 =>l3).ToArray();
            Console.WriteLine(string.Join(" ", list3));

            #endregion A - Common Elements

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"

            #region B - Exclude all but list 1

            int[] list4 = list1.Where(l1=>!list2.Any(l2=>l1==l2)).Select(l3=>l3).ToArray();
            Console.WriteLine(string.Join(" ", list4));

            #endregion B - Exclude all but list 1

            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"

            #region C - Exclude all but list 2

            int[] list5 = list2.Where(l2=>!list1.Any(l1=>l1==l2)).ToArray();
            Console.WriteLine(string.Join(" ", list5));

            #endregion C - Exclude all but list 2

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}