using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace ManipulatingWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________________________");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Bubble Sorting");
                Console.WriteLine("2. Find the smallest element of array");
                Console.WriteLine("3. Find the sum elements of array");
                Console.WriteLine("4. Find the average number of array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("_____________________________________________________");
                var input = Console.ReadLine();
                try
                {
                    switch (input)
                    {
                        case "1":
                            BubbleSort(array);
                            break;
                        case "2":
                            MinElement(array);
                            break;
                        case "3":
                            SumElements(array);
                            break;
                        case "4":
                            Console.WriteLine("Average number: " + AverageNumber(array));
                            break;
                        case "5":
                            Console.WriteLine("Good bye");
                            return;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }


        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])

                    {
                        // Меняем элементы местами
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");

            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }

        static void MinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The smallest element of array: " + min);
        }
        static void SumElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("The sum elements of array: " + sum);
        }

        static double AverageNumber(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / arr.Length;
            return average;
        }
    }
}
