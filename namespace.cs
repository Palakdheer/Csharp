using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using l1 = lab3;
using m1 = lab3.myNameSpace;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            m1.A obj = new m1.A();
            obj.print();
            l1.A obj1 = new l1.A();
            obj1.print();
        }
    }
}
namespace lab3
{
    namespace myNameSpace
    {
        class A
        {
            public void print()
            {
                Console.WriteLine("hello palak here");
               // Console.ReadKey();
            }

        }
    }
    class A
    {
        public void print()
        {
            Console.WriteLine("hello palak");
            Console.ReadKey();
        }

    }

}
