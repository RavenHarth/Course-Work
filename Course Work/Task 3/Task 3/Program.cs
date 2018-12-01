using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number from 1 to 7!");
            int A = int.Parse(Console.ReadLine());
            if (A == 1)
            {
                Console.WriteLine("Monday");
            }
           else if (A == 2)
            {
                Console.WriteLine("Tuesday");
            }
           else if (A == 3)
            {
                Console.WriteLine("Wednsday");
            }
          else if (A == 4)
            {
                Console.WriteLine("Thursday");
            }
           else if (A == 5)
            {
                Console.WriteLine("Friday");
            }
           else if (A == 6)
            {
                Console.WriteLine("Saturday");
            }
           else if (A == 7)
            {
                Console.WriteLine("Sunday");
            }
                    else 
                    {
                Console.WriteLine("Too Large of a number!");

                    }
        }
    }
}
