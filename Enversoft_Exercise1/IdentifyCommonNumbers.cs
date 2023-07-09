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
            List<int> commonNumbers=new List<int>();
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        commonNumbers.Add(list1[i]);
                    }
                }
            }
            return commonNumbers.ToArray();
        }
    }
}
