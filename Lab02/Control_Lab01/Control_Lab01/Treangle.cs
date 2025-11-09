
namespace Control_Lab01
{
    internal class Treangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the perimeter of treangle more then 0");
            double perimetr = Double.Parse(Console.ReadLine());

            double semiperimetr = perimetr / 2;
            double side = perimetr / 3;
            double S = Math.Sqrt(semiperimetr * (semiperimetr - side) * (semiperimetr - side) * (semiperimetr - side));
            Console.WriteLine("Сторона, Площадь");
            Console.WriteLine($"{side:F2}, {S:F2}");
            
        }
    }
}
