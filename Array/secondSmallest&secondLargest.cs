using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 1, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Program obj = new Program();
            Program obj2 = new Program();
            int m = obj.SecondMax(arr);
            Console.WriteLine("the second largest element in the array is " + m);
            int n = obj2.smallest(arr);
            Console.WriteLine("the second smallest element in the " + n);
            Console.ReadLine();
        }
        int SecondMax(int[] a)
        {
            int secondmax = a[0], max = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    secondmax = max;
                    max = a[i];
                }
            }
            return secondmax;
        }
        int Secondsmall(int[] a)
        {
            int small = a[0], secondsmall = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < small) // { 2, 4, 1, 3, 5, 6, 7, 8, 9, 10, 11, 12,13};
                {
                    secondsmall = small;
                    small = a[i];
                }
            }
            return secondsmall;
        }
    }
}
