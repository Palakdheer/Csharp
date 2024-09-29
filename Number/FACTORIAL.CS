  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n");
            int n = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++) {
                f = f * i;
            }
            Console.WriteLine("the factorial of given number is " + f);
            Console.ReadLine();
        }
       
} }
