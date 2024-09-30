using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = {1,2,3,5,6,7};
            Console.WriteLine("the element to be found ");
            int n = int.Parse(Console.ReadLine());
            Program obj1 = new Program();
            int b= obj1.search(a, n);
            if (b != -1)//if the method returns 1
            {
                Console.WriteLine("th element to be found is " + a[b] +  " at the  " + b + " position");
            }
            else//if the method returns -1 
            {
                Console.WriteLine("the element is not found ");
            }
           
            Console.ReadLine();
        }
        int search(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    return i;
                }

            }
            return -1;
            
        }
    }
}
