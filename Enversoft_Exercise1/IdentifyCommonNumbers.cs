using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enversoft_Exercise1
{
    public class IdentifyCommonNumbers
    {
        public int[] GetCommonNumbers(int[] list1, int[] list2)
        {
            List<int> firstList = list1.ToList();
            List<int> secondList = list2.ToList();
            List<int> commonNumbers=new List<int>();
            foreach (int number in firstList)
            {
                if (secondList.Contains(number))
                {
                    commonNumbers.Add(number);
                }
            }
            return commonNumbers.ToArray();
        }
    }
}
