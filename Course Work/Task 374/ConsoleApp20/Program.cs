using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int x, s = 0;
            int product = 1;
            int counter = 0;
            int number = 1;

            do
            {
                Console.WriteLine("Enter a number: ");
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                    s += x;
                if (counter == 0)
                {
                    k = x;
                }
                counter++;

            } while (x != 0);
            Console.WriteLine("Sum: " + s);

            Console.WriteLine("Input ten random numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number: ");
                number = int.Parse(Console.ReadLine());
                if (number >= 2 && number <= 12)
                {
                    product *= number;                    
                }
            }
            Console.WriteLine("The product of the ten numbers: " + product);

            Console.WriteLine("Enter length of the array of numbers: ");
            int v = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Random r = new Random();
            int sum = 0; 


            for (int i = 0; i < arr.Length; i++)
            {
                int rand = r.Next(byte.MinValue, byte.MaxValue);
                arr[i] = rand;

                if (rand % 2 ==0)
                {
                    sum += rand;
                }
            }
            Console.Write("The array with random numbers is: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of the even numbers in the array is: " + sum);







            Console.ReadKey();
        }
    }
}
