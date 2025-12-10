using System.Security.Cryptography.X509Certificates;

namespace Task4
{
    using System;

    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
        }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public void Init()
        {
            Console.WriteLine("Input sides of Triangle:");

            Console.Write("Side A: ");
            while (!double.TryParse(Console.ReadLine(), out sideA) || sideA <= 0)
            {
                Console.Write("Incorrect input. Input positive number for side A: ");
            }

            Console.Write("Side B: ");
            while (!double.TryParse(Console.ReadLine(), out sideB) || sideB <= 0)
            {
                Console.Write("Incorrect input. Input positive number for side B: ");
            }

            Console.Write("Side C: ");
            while (!double.TryParse(Console.ReadLine(), out sideC) || sideC <= 0)
            {
                Console.Write("Incorrect input. Input positive number for side C: ");
            }
        }


        public bool ValidTriangle()
        {

            return (sideA + sideB > sideC) &&
                   (sideA + sideC > sideB) &&
                   (sideB + sideC > sideA);
        }

        public double CalcPerimeter()
        {
            if (!ValidTriangle())
            {
                Console.WriteLine("Triangle with this sides not exists!");
                return 0;
            }
            return sideA + sideB + sideC;
        }

        public double CalcArea()
        {
            if (!ValidTriangle())
            {
                Console.WriteLine("Triangle with this sides not exists!");
                return 0;
            }

            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public void DisplaySides()
        {
            Console.WriteLine($"Sides of Triangle:");
            Console.WriteLine($"A = {sideA:F2}");
            Console.WriteLine($"B = {sideB:F2}");
            Console.WriteLine($"C = {sideC:F2}");
        }

        class Program
        {
            static void Main()
            {



                Triangle triangle = new Triangle();


                triangle.Init();




                triangle.DisplaySides();


                if (triangle.ValidTriangle())
                {
                    Console.WriteLine("\nTriangle exists.");


                    double perimeter = triangle.CalcPerimeter();
                    Console.WriteLine($"Perimetr of Triangle: {perimeter:F2}");


                    double area = triangle.CalcArea();
                    Console.WriteLine($"Square of triangle: {area:F2}");
                }
                else
                {
                    Console.WriteLine("\nTriangle with this sides not exists!");

                }



                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}