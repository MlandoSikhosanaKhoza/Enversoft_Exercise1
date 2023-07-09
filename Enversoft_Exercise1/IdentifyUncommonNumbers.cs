using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enversoft_Exercise1
{
    public class IdentifyUncommonNumbers
    {
        public int[] GetUncommonNumbersFromPrimaryList(int[] primayNumberList, int[] secondaryNumberList)
        {
            List<int> primaryList=primayNumberList.ToList();
            List<int> secondaryList=secondaryNumberList.ToList();
            List<int> uncommonList=new List<int>();
            foreach (int primary in primaryList)
            {
                if(!secondaryList.Contains(primary))
                {
                    uncommonList.Add(primary);
                } 
            }
            
            return uncommonList.ToArray();
        }
    }
}
