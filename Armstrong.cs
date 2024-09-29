using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 157;
            int temp = n;
            int sum=0;
                while (n != 0)
                {
                    int m=n%10;
                    sum = sum + m * m * m;
                    n = n / 10;

                }
            if (temp == sum) {
                Console.WriteLine("YES IS THE ARMSTRONG NUMBER " + temp);
            }
            else
            {
                Console.WriteLine("no it IS THE NOT ARMSTRONG NUMBER " + temp);
            }
            Console.ReadLine();

        }
       
    }
}
