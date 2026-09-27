using System;
using System.Linq;

namespace LabWork2App
{
    public class Variant9Service
    {
        // 1. Calculate the number of vowels in a string
        public int CountVowels(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            return input.Count(c => vowels.Contains(char.ToLower(c)));
        }

        // 2. Find the second largest distinct element in an array
        public int FindSecondLargest(int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            var distinctOrdered = array.Distinct().OrderByDescending(x => x).ToArray();

            if (distinctOrdered.Length < 2)
            {
                throw new InvalidOperationException("Array must contain at least two distinct elements.");
            }

            return distinctOrdered[1];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new Variant9Service();

            string sampleText = "Hello World";
            Console.WriteLine($"Vowels count: {service.CountVowels(sampleText)}");

            int[] numbers = { 3, 15, 1, 9, 15, 12 };
            Console.WriteLine($"Second largest: {service.FindSecondLargest(numbers)}");
        }
    }
}