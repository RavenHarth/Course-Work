using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter H:");
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter R:");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter r:");
            double r = double.Parse(Console.ReadLine());
            double V = Math.PI * H * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2)) / 3;
            Console.WriteLine($"The volume of the cone is {V}");
        }
    }
}
