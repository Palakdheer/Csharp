using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n");
            int n = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(n +  "is  prime number");
            }
            else
            {
                Console.WriteLine(n +  "IS not THE PRIME NUMBER");
              
            }
            Console.ReadLine();
        }
    }
}
