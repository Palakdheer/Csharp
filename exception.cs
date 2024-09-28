using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine("value of {0}", arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.WriteLine("end of program");
            Console.ReadLine();
       
        }
    }
}
