using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindrominRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100,rev;
           
            for (int i = n; i <= 200; i++)
            {
               int CurrentNumber = i;
                rev = 0;
                while (CurrentNumber != 0)
                {
                    int m = CurrentNumber % 10;
                    rev = rev * 10 + m;
                    CurrentNumber = CurrentNumber / 10;
                }
                    if (i == rev)
                    {
                        Console.WriteLine("the palindroms are "+ rev);
                    }

                
            }
            Console.ReadLine(); 

        }
    }
}

