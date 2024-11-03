namespace Identitical_Twins_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = IdenticalTwin([1, 1, 1, 1]);
            Console.WriteLine(count);
        }
        public static int IdenticalTwin(int[] arr)
        {
            int count = 0;
            for(int i=0; i<arr.Length-1; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
