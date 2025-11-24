namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());

           
            int[] array = FillArray(size);

            Console.WriteLine("Your array:");
            PrintArray(array);

            
            int sum = CalcSum(array);
            Console.WriteLine($"Sum of all elements: {sum}");

            double average = CalcAverage(array);
            Console.WriteLine($"Average meaning: {average:F2}");

            var (positiveSum, negativeSum) = CalcPosNegSum(array);
            Console.WriteLine($"Sum of positive: {positiveSum}, Sum of negative: {negativeSum}");

            var (evenSum, oddSum) = CalcEvenOddIndexSum(array);
            Console.WriteLine($"Sum of even indexes: {evenSum}, Sum of odd indexes: {oddSum}");

            var (maxIndex, minIndex) = FindMaxMinIndex(array);
            Console.WriteLine($"Max element: {array[maxIndex]} (index {maxIndex}), " +
                             $"Min element: {array[minIndex]} (index {minIndex})");

            int product = CalcProductBetweenMinMax(array);
            Console.WriteLine($"f. Product between min and max: {product}");
        }

        
        static int[] FillArray(int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Input {size} of array elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        
        static int CalcSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }

        
        static double CalcAverage(int[] array)
        {
            if (array.Length == 0) return 0;
            return (double)CalcSum(array) / array.Length;
        }

       
        static (int positiveSum, int negativeSum) CalcPosNegSum(int[] array)
        {
            int positiveSum = 0;
            int negativeSum = 0;

            foreach (int element in array)
            {
                if (element > 0)
                    positiveSum += element;
                else if (element < 0)
                    negativeSum += element;
            }

            return (positiveSum, negativeSum);
        }

        
        static (int evenSum, int oddSum) CalcEvenOddIndexSum(int[] array)
        {
            int evenSum = 0; 
            int oddSum = 0;  

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    evenSum += array[i];
                else
                    oddSum += array[i];
            }

            return (evenSum, oddSum);
        }

        
        static (int maxIndex, int minIndex) FindMaxMinIndex(int[] array)
        {
            if (array.Length == 0)
                return (-1, -1);

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
                if (array[i] < array[minIndex])
                    minIndex = i;
            }

            return (maxIndex, minIndex);
        }

       
        static int CalcProductBetweenMinMax(int[] array)
        {
            if (array.Length < 2)
                return 0;

            var (maxIndex, minIndex) = FindMaxMinIndex(array);

            
            int start = Math.Min(maxIndex, minIndex);
            int end = Math.Max(maxIndex, minIndex);

            
            if (end - start <= 1)
                return 0;

            int product = 1;
            for (int i = start + 1; i < end; i++)
            {
                product *= array[i];
            }

            return product;
        }
    }
}