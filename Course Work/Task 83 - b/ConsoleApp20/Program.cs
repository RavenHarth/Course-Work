using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 100, i = 1; i <= 50; i++, j--)
            {
                Console.Write(j--  +",");
                Console.Write(i++  + "," + i + "," + j+ ",");
            }
        }
    }
}

 