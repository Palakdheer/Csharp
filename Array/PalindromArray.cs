using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3 };
            int Flag = 0;
            int[]b=new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                 b[i] = arr[i];
            
            }
            Array.Reverse(b);


            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != b[i])
                {
                    Flag = 1;
                    break;
                }

            }
            if (Flag == 0) {
                Console.WriteLine("palindrom array");

            }
            else
            {
                Console.WriteLine("not palindrom array");
            }
            Console.ReadLine();
        }
        
    }
}
