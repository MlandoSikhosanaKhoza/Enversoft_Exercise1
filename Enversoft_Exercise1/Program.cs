using Enversoft_Exercise1;
using System;
namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// 1. There are 2 solutions to each question because I don't know which you prefer
        /// 2. !NB Comment out the one you want if you want to you can just look at the unit tests
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            #region Question A - Common Elements
            /*_______________________________________________________Question A - Start______________________________________________*/

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.

            //Here is the Lambda version
            #region A - Solution 1 - Lambda
            /* Uncomment the lines within this region to get the results from the Lambda */
            /* NB! Comment out the algoithmic approach if you want to see this one CHECK THE REGION */

            //int[] list3 = list1.Where(l1 => list2.Any(l2 => l1 == l2)).ToArray();

            #endregion A - Solution 1 - Lambda

            //It came to me that you might want me to demonstrate in a more algorithmic approach
            #region A - Solution 2 - Algorithimic approach
            /* Uncomment the lines within this region to get the results from the algorithimic approach one */
            /* NB! Comment out the lambda approach if you want to see this one CHECK THE REGION */

            IdentifyCommonNumbers commonNumbers = new IdentifyCommonNumbers();
            int[] list3 = commonNumbers.GetCommonNumbers(list1, list2);

            #endregion A - Solution 2 - Algorithimic approach

            //Output
            Console.WriteLine(string.Join(" ", list3));
            //*______________________________________________________Question A - End_________________________________________________*//
            #endregion Question A - Common Elements

            /***************************************************************************************************************************/

            #region Question B - Exclude all but list 1
            /*_______________________________________________________Question B - Start______________________________________________*/

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"



            //Here is the Lambda version
            #region B - Solution 1 - Lambda
            /* Uncomment the lines within this region to get the results from the Lambda */
            /* NB! Comment out the algoithmic approach if you want to see this one CHECK THE REGION */

            //int[] list4 = list1.Where(l1=>!list2.Any(l2=>l1==l2)).ToArray();

            #endregion B - Solution 1 - Lambda

            //It came to me that you might want me to demonstrate in a more algorithmic approach
            #region B - Solution 2 - Algorithimic approach
            /* Uncomment the lines within this region to get the results from the algorithimic approach one */
            /* NB! Comment out the lambda approach if you want to see this one CHECK THE REGION */

            IdentifyUncommonNumbers identifyUncommonNumbersForList1 = new IdentifyUncommonNumbers();
            int[] list4 = identifyUncommonNumbersForList1.GetUncommonNumbersFromPrimaryList(list1, list2);

            #endregion B - Solution 2 - Algorithmic approach

            //Output
            Console.WriteLine(string.Join(" ", list4));
            //*_________________________________________________________Question B - End_____________________________________________*//
            #endregion Question B - Exclude all but list 1

            /***************************************************************************************************************************/

            #region Question C - Exclude all but list 2
            /*_______________________________________________________Question C - Start______________________________________________*/
            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"

            #region C - Solution 1 - Lambda
            /* Uncomment the lines within this region to get the results from the Lambda */
            /* NB! Comment out the algoithmic approach if you want to see this one CHECK THE REGION */

            //int[] list5 = list2.Where(l2=>!list1.Any(l1=>l1==l2)).ToArray();

            #endregion C - Solution 1 - Lambda

            #region C - Solution 2 - Algorithimic approach
            /* Uncomment the lines within this region to get the results from the algorithimic approach one */
            /* NB! Comment out the lambda approach if you want to see this one CHECK THE REGION */

            IdentifyUncommonNumbers identifyUncommonNumbersForList2 = new IdentifyUncommonNumbers();
            int[] list5 = identifyUncommonNumbersForList2.GetUncommonNumbersFromPrimaryList(list2, list1);

            #endregion C - Solution 2 - Algorithimic approach

            //Output
            Console.WriteLine(string.Join(" ", list5));
            //*_________________________________________________________Question C - End_____________________________________________*//
            #endregion Question C - Exclude all but list 2

            /***************************************************************************************************************************/
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}