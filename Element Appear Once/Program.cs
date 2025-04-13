namespace Element_Appear_Once
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = ElementAppearOnce.ElementOnce([4, 1, 2, 1, 2]);
            Console.WriteLine(result);
        }
    }

    class ElementAppearOnce
    {
        public static int ElementOnce(int[] nums)
        {
            //int max = 0;
            //for(int i = 0; i < nums.Length; i++)
            //{
            //    max = Math.Max(max, nums[i]);

            //}
            //int[] hash = new int[max+1];
            //for(int i = 0; i < nums.Length; i++)
            //{
            //    hash[nums[i]] += 1;
            //}
            //for(int i = 0; i < hash.Length; i++)
            //{
            //    if (hash[i] == 1)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
            int xor = 0;
            int j = 0;
            for(int i = 0; i < nums.Length-1; i++)
            {
                xor = xor ^ nums[i];
                
            }
            return xor;
        }
    }
}
