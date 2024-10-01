using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, };
            int Flag = 0,i=0,j=arr.Length-1;
            while (i<j)
            {
                if(arr[i]!=arr[j])
                {
                    Flag=Flag+1;
                    break;
                }
                i++;
                j--;
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
