using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
  
        void InsertionSort(int[]a,int N)
        {
            int i, j,t=0;
            for (i = 1; i < N; i++)
            {
                t = a[i];
                j = i-1;

                while (j >= 0 && t < a[j])
                {
                    a[j+1] = a[j];
                    j--;
                }
                a[j+1 ] = t;
              }
            }

        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,5,4,8,16,13};
            int n=arr.Length;
            Program obj1= new Program();
            obj1.InsertionSort(arr, n);
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");
               
            }
            Console.ReadLine();
        }
    }
}
