using System;

namespace ConsoleApplication1
{
    public static class MathUtilities
    {
        // Static method to calculate the average of an array of integers
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
            }

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        // Static method to find the maximum value in an array of integers
        public static int FindMaximum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
            }

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example array of integers
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            try
            {
                // Calculate the average of the array
                double average = MathUtilities.CalculateAverage(myNumbers);
                Console.WriteLine($"The average is: {average}");

                // Find the maximum value in the array
                int max = MathUtilities.FindMaximum(myNumbers);
                Console.WriteLine($"The maximum value is: {max}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}