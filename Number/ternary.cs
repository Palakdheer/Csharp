using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter the number");
            int n=int.Parse(Console.ReadLine());
            bool isEven;
            isEven=(n%2==0)?true:false;
            Console.WriteLine(isEven);
            Console.ReadLine();
        }
    }
}
