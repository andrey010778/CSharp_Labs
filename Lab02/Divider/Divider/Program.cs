namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int j = Int32.Parse(Console.ReadLine());
            int k = i / j;
            Console.WriteLine($"The result of dividing {i} by {j} is {k}");
            int m = i * j;
            Console.WriteLine($"The result of * {i} and {j} is {m}");
            
        }
    }
}
