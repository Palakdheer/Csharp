using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    internal class Program
    {
  
        void bubbleSort(int[]a,int N)
        {
            int i, j, temp = 0;
            for (i = 0; i < N - 1; i++) {
                for (j = 0; j < N - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
              }
            }

        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,5,4,8,16,13};
            int n=arr.Length;
            Program obj1= new Program();
            obj1.bubbleSort(arr, n);
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");
               
            }
            Console.ReadLine();
        }
    }
}
