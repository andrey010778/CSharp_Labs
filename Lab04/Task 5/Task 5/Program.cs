namespace Task_5
{
    class QuadraticEquation
    {
        
        public static int CalcRoots(double a, double b, double c, ref double x1, ref double x2)
        {
            
            double discr = b * b - 4 * a * c;

            
            if (discr < 0)
            {
                return -1;
            }

            
            if (discr == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return 0;
            }

            
            double sqrtD = Math.Sqrt(discr);
            x1 = (-b + sqrtD) / (2 * a);
            x2 = (-b - sqrtD) / (2 * a);

            return 1;
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

            
            double x1 = 0, x2 = 0;

            
            int result = QuadraticEquation.CalcRoots(a, b, c, ref x1, ref x2);

            
            switch (result)
            {
                case -1:
                    Console.WriteLine($"No roots of quaratic quation with coefs a = {a}, b = {b}, c = {c}");
                    break;

                case 0:
                    Console.WriteLine($"One root of quaratic quation with coefs a = {a}, b = {b}, c = {c} is: x1 = x2 = {x1:F4}");
                    break;

                case 1:
                    Console.WriteLine($"Roots of quaratic quation with coefs a = {a}, b = {b}, c = {c} equals: x1 = {x1:F4}, x2 = {x2:F4}");
                    break;
            }

        }
    }
}