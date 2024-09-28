using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Program
    {
        int add(int a, int b)
        {
            return a + b;
        }
        int add(int a, int b, int c)
        {
            return a + b + c;
        }
    
        static void Main(string[] args)
        {
        Program obj1 = new Program();
       int Sum1= obj1.add(3, 4);
            Console.WriteLine(Sum1);
       int sum2=obj1.add(3, 4, 5);
            Console.WriteLine(sum2);
            Console.ReadKey();  


        }
    }}

