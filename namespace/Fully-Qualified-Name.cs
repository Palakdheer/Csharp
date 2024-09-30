using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            name3.A obj=new name3.A();
            obj.print1();

        }
    }
}
namespace name3
{
    class A
    {
        public void print1()
        {
            Console.WriteLine("hello how are you");
            Console.ReadLine();
        }
    }
}
