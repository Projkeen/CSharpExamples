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
                Console.WriteLine("2. Find the biggest element of array");
                Console.WriteLine("3. Find the sum elements of array");
                Console.WriteLine("4. Find the average number of array");
                Console.WriteLine("5. Find the smallest number of array and square it");
                Console.WriteLine("6. Find the smallest number of array, square it and show new array");
                Console.WriteLine("7. Exit");
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
                            MaxElement(array);
                            break;
                        case "3":
                            SumElements(array);
                            break;
                        case "4":
                            Console.WriteLine("Average number: " + AverageNumber(array));
                            break;
                        case "5":
                            SquareSmallestNumber(array);
                            break;
                        case "6":
                            ChangeSmallestNumber(array);                            
                            Console.WriteLine("New array:");
                            foreach (int num in array)
                            {
                                Console.Write(num + " ");
                            }
                            break;
                        case "7":
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

        static void MaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The biggest element of array: " + max);
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

        static void SquareSmallestNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            min *= min;         
            
            Console.WriteLine("Smallest number in an array squared: "+ min);


        }

        static int[] ChangeSmallestNumber(int[] arr)
        {
            int minIndex = 0;
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            arr[minIndex] *= arr[minIndex];

            return arr;
        }
    }
}
