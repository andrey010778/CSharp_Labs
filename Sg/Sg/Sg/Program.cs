namespace Sg
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int number = 12345;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;  
                number /= 10;        
            }

            Console.WriteLine($"Сумма цифр: {sum}");

        }
    }
}

