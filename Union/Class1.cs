using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union
{
    class Class1
    {
        public static int[] FindUnion(int[] nums, int[] num2, int m, int n)
        {
            var list = new List<int>();
            for(int i = 0; i < m; i++)
            {
                list.Add(nums[i]);
            }
            for(int i = 0; i < n; i++)
            {
                if (!list.Contains(num2[i]))
                {
                    list.Add(num2[i]);
                }
            }
            list.Sort();
            return list.ToArray();
        }
    }
}
