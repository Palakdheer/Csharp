using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofArray
{
    internal class Program
    {
        int sum1(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum = sum + i;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Program obj1= new Program();
            int sum=obj1.sum1(arr);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
       
    }
}
