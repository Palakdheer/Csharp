using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 500;
            Object obj = num;//BOXING
            Console.WriteLine("object value:"+obj);
            int i = (int)obj;//UNBOXING
            Console.WriteLine("integer value:" + i);
            Console.ReadKey();
        }
    }
}
