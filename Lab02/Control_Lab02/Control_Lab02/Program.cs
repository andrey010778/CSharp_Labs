namespace Control_Lab02
{
    public struct Distance
    {
        public int feet;
        public int inches;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Distance d1, d2, d3;

            Console.WriteLine("Enter first distance:");
            Console.WriteLine("Feets:");
            d1.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Inches:");
            d1.inches = int.Parse(Console.ReadLine());

            while (d1.inches >=12)
            {
                Console.WriteLine("Error: Inches can't be 12 or more!");
                Console.WriteLine("Input inches again");
                d1.inches = int.Parse(Console.ReadLine());
            }
                



            Console.WriteLine("Enter second distance:");
            Console.WriteLine("Feets:");
            d2.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Inches:");
            d2.inches = int.Parse(Console.ReadLine());

            while (d2.inches >= 12)
            {
                Console.WriteLine("Error: Inches can't be 12 or more!");
                Console.WriteLine("Input inches again");
                d2.inches = int.Parse(Console.ReadLine());
            }

            int totalInches = (d1.feet * 12 + d1.inches) + (d2.feet * 12 + d2.inches);
            d3.feet = totalInches / 12;
            d3.inches = totalInches % 12;

            Console.WriteLine("Results:");
            Console.WriteLine($"First distance: {d1.feet}' - {d1.inches}\"");
            Console.WriteLine($"Second distance: {d2.feet}' - {d2.inches}\"");
            Console.WriteLine($"Total distance: {d3.feet}' - {d3.inches}\"");

        }
    }
}
