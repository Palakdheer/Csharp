using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using l1 = name3.myname;
namespace name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1.A obj=new l1.A();
            obj.print1();
            l1.A obj2 = new l1.A();
            obj2.print1();

        }
    }
}
namespace name3
{
    namespace myname
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
}
