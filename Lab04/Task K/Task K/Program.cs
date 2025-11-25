using System.Net.WebSockets;

namespace Task_K
{
   
        class QuadraticEquation
        {

            public static (int status, double x1, double x2) CalcRoots(double a, double b, double c)
            {

                double discr = b * b - 4 * a * c;


                if (discr < 0)
                {
                    return (-1, 0 ,0);  
                }


                if (discr == 0)
                {
                    double x = -b / (2 * a);
                    return (0, x, x);
                }


                double sqrtD = Math.Sqrt(discr);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);

                return (1, x1, x2);
            }
        }

        class Program
        {
            static void Main()
            {

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());


                var (status, x1, x2) = QuadraticEquation.CalcRoots(a, b, c);


                switch (status)
                {
                    case -1:
                        Console.WriteLine($"No roots of quaratic quation with coefs a = {a}, b = {b}, c = {c}");
                        break;

                    case 0:
                        Console.WriteLine($"One root of quaratic quation with coefs a = {a}, b = {b}, c = {c} is x = {x1:F4}");
                        break;

                    case 1:
                        Console.WriteLine($"Roots of quaratic quation with coefs a = {a}, b = {b}, c = {c} equals: x1 = {x1:F4}, x2 = {x2:F4}");
                        break;
                }

            }
        }
    }