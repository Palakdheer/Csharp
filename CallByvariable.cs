using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyvariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10; int y = 20, z;
            Program obj = new Program();
           //obj.swap(x, y);
            //Console.WriteLine(c);
           int d= obj.AddParams(1, 2, 3, 3, 4, 5);
            Console.WriteLine(d);
            obj.add(x, y,out z);
            Console.WriteLine(z);
            obj.swap(ref x,ref  y);
            Console.WriteLine("value of x:"+x+ "Value of y:"+y);
            Console.ReadKey();



        }
        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void add(int x, int y, out int z)
        {
            z = x + y;
        }
        public int AddParams(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;

           
        }
    }
}
