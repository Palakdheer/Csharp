using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "palak";
            string s2 = "hii ";

             Console.WriteLine(s2 + s);//using arthimetic operator
            s2 = string.Concat(s2, s);//by using built-in function
            
            Console.WriteLine(s2);
           

            Console.ReadLine();
        }
    }
}
