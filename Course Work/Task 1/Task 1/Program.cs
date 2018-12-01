using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string smiley = "2074";
            int value = 2074;
            string binary = Convert.ToString(value, 16);
            string binary1 = Convert.ToString(value, 8);
            string binary2 = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            Console.WriteLine(binary1);
            Console.WriteLine(binary2);
            Console.ReadKey(true);
        }
    }
}
