using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CheckArray
    {
        public static bool Check(int[] arr)
        {
            int count = 0;  
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[(i + 1) % arr.Length])
                {
                    count++;
                }
                if(count > 1)
                {
                    return false;
                }       
            }
            return true;        

        }
    }
}
