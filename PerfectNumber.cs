using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, i = 1;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                    i++;
            }
            if (sum == n)
            {
                Console.WriteLine("it is a perfect number", n);
            }
            else
            {
                Console.WriteLine("it is not a perfect number", n);
           
            }
            Console.ReadLine();
        }
    }
}
