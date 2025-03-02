using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public static int SecondLargest(int[] array)
        {
            int f = 0;
            int s = -1;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > f)
                {
                    s = f;
                    f = array[i];
                }
                else if (array[i]<f && array[i] > s)
                {
                    s = array[i];
                }
            }
            return s;
        }
    }
}
