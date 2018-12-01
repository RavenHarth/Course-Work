using System;

namespace Task_405
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number of elements of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            if (size >= 2 && size <= 25)
            {
                Input(arr);
            }
            else
            {
                Console.WriteLine("Invalid number of elements.");
            }

            Console.WriteLine("Insert a number for 'k': ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("The product is: " + Prod(arr, k));

            int counter = 0;
            Console.WriteLine("The number is: " + Broi(arr, counter));

            Console.ReadKey(true);
        }

        static void Input(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static int Prod(int[] arr, int k)
        {
            int prod = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0 && arr[i] < k)
                {
                    prod *= arr[i];
                }
            }
            return prod;

        }

        static double Broi(int[] arr, int counter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 100 && arr[i] <= 666 && arr[i] % 3 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}