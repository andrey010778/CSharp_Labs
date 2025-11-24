namespace Task04
{

    public class Operation
    {
        
        public static double CalculateSquare(double a, double b, double c)
        {
            
            if (!IsTriangleValid(a, b, c))
            {
                throw new ArgumentException("Triangle with these side cannot exist");
            }

            
            double p = (a + b + c) / 2;

            
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        
        private static bool IsTriangleValid(double a, double b, double c)
        {
           
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c &&
                   a + c > b &&
                   b + c > a;
        }

        
        public static double CalculateSquare(double side)
        {
                                 
            double area = (Math.Sqrt(3) / 4) * side * side;

            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            

                Console.WriteLine("Choose a type of Triangle: 1 - Equal sides 2 - Different sides: ");

                string choice = Console.ReadLine();

                double area = 0;

                if (choice == "1")
                {

                    Console.Write("Input length of side ");
                    double side = double.Parse(Console.ReadLine());

                    area = Operation.CalculateSquare(side);

                    Console.WriteLine($"Square of equal sides triangle {side}: {area:F2}");
                }
                else if (choice == "2")
                {

                    Console.Write("Input the length of side a: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Input the length of side b: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Input the length of side c: ");
                    double c = double.Parse(Console.ReadLine());

                    area = Operation.CalculateSquare(a, b, c);

                    Console.WriteLine($"Square of triangle with sides {a}, {b}, {c}: {area:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid choise, please choose 1 or 2");
                }
            
        }
    }
}