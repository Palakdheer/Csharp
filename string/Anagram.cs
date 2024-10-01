using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();
            if (c1.Length != c2.Length)
            {
                Console.WriteLine("not a Anagram string");
            }
            else
            {
                Array.Sort(c1);
                string s1=new string(c1);
                Array.Sort(c2);
                string s2=new string(c2);
                if (s1.Equals(s2))
                {
                    Console.WriteLine("its is Anagram string ");
                }
                else {
                    Console.WriteLine("not an Anagram string");

                }
                Console.ReadLine();
            }
        }
    }
}
