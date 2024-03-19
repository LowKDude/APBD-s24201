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
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            // Example array of integers
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            try
            {
                // Calculate the average of the array
                double average = MathUtilities.CalculateAverage(myNumbers);
                // Output the average
                Console.WriteLine($"The average is: {average}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


//Modification 1
//Modification 2
//Modification 3