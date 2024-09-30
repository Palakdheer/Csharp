using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    internal class Program
    {
  
        void SelectionSort(int[]a,int N)
        {
            int i, j, pos = 0,min=0;
            for (i = 0; i < N - 1; i++)
            {
                min = a[j];
                pos = j;
            
                for (j = i+1; j < N; j++)
                {
                    if (min > a[j])
                    {
                        min = a[j];
                        pos = j;
                    }
                    if (pos != i)
                    {
                        a[pos] = a[i];
                        a[i] = min;
                    }
                }
              }
            }

        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,5,4,8,16,13};
            int n=arr.Length;
            Program obj1= new Program();
            obj1.SelectionSort(arr, n);
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");
               
            }
            Console.ReadLine();
        }
    }
}
