using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(arr);
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
                           
            }
            Console.ReadKey();
        }
    }
}
