namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = Class1.FindUnion([1, 2, 3, 4, 5], [2, 3, 4, 4, 5], 5, 5);
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
