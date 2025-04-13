using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class class1
    {
        public static int FindOccurance(int[]nums, int x)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
