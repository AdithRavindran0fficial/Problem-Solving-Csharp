using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurance_of_Element
{
    internal class Class1
    {
        public static void Occurance(int[] array)
        {
            var max = 0;
            for(int k=0; k < array.Length; k++)
            {
                if (array[k] > max)
                {
                    max = array[k];
                }
            }
            int[] hash = new int[max + 1];
            for(int j = 0; j <= array.Length-1; j++)
            {
                hash[array[j]] = hash[array[j]] + 1;
            }
           
            
            for(int i=0; i < hash.Length; i++)
            {
                if(hash[i] != 0)
                {
                    Console.WriteLine(hash[i]);
                }
            }
        }
    }
}
