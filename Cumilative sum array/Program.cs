namespace Cumilative_sum_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CumilativeSum([1,2,3,4]);
        }
        public static void CumilativeSum(int[] arr)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                list.Add(sum);
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
