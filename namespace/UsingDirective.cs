using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using l = name3;
namespace name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l.A obj=new l.A();
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
