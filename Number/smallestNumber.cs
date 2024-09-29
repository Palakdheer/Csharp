
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {  3, 2, 4, 5, 6, 3, 2 };
             Program s = new Program();

            int c = s.smallestNumber(a);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        int smallestNumber(int[] arr)
        {
            int small = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
               
                if (arr[i] < small)
                {
                    small = arr[i];

                }
            }
            return small;

        }
        }

    } 
