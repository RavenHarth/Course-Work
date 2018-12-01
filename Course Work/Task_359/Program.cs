using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_359
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input String S:");
            string S = Console.ReadLine();
            DoMyCheck(S);
            
        }
        static string DoMyCheck(string S)
        {
            
            Console.WriteLine("Input String Х");
            string X = Console.ReadLine();
            int Choice;
            Console.WriteLine("For String A and B Present Press 1");
            Console.WriteLine("For String A and B Following Press 2");
            Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                Console.WriteLine("Input String A");
                string A = Console.ReadLine();

                Console.WriteLine("Input String B");
                string B = Console.ReadLine();

                string Combined1 = A + B + X;
                Console.WriteLine("Present of Strings А and В : {0}", Combined1);

                if (S.Contains(X)&&Combined1.Contains(X))
                {
                    Console.WriteLine("In String {0} there is a Static String {1}, Followed by {2}", S, X, A+B);
                }
                else
                {
                    Console.WriteLine("Does not contain String Х");
                }


            }
            else
            {
                if(Choice == 2)
                {
                    Console.WriteLine("Input String A");
                    string A = Console.ReadLine();

                    Console.WriteLine("Input String B");
                    string B = Console.ReadLine();

                    string Combined2 = X + A + B;
                    Console.WriteLine("Followed by Strings А and В : {0}", Combined2);
                    if (S.Contains(X) && Combined2.Contains(X))
                    {
                        Console.WriteLine("String {0} Contains Static String {1}, Followed by {2}", S, X, A + B);
                    }
                    else
                    {
                        Console.WriteLine("Does not contain String Х");
                    }

                }
                else
                {
                    Console.WriteLine("1 or 2 not {0}", Choice);
                }
            }

            return X;
            
        }
        
    }
}
