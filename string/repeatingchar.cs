using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace repeatingchar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "palakkdheer";
            char[] c = a.ToCharArray();
            
            
            Console.WriteLine(a);
            for (int i = 0; i < c.Length; i++)
            {
                int count = 0;
                for (int j = i+1; j < c.Length; j++)
                {
                    

                        if (c[i] == c[j])
                        {
                            count++;
                            break;
                        }
                    }
                

                if (count>=1)
                {
                    Console.WriteLine("THE REPEATING CHARACTERS ARE " +c[i]);
                 
                }
            }
            Console.ReadLine();
        }
    }
}
