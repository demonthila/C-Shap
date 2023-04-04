using System;

namespace SelectionSortArray
{
    class Program
    {
        static int FindMax(int[] numbers, int startIndex)
        {
            int maxIndex = startIndex;
            for (int i = startIndex + 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void SwapArrayNumbers(int[] numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }

        static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxIndex = FindMax(numbers, i);
                if (maxIndex != i)
                {
                    SwapArrayNumbers(numbers, i, maxIndex);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 4, 3, 2, 1 };
            Console.WriteLine("Array elements before sorting: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            SelectionSort(numbers);

            Console.WriteLine("Array elements after sorting: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
