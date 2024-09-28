using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hEllo worLd";
            s += ' ';
            s = s.ToLower();
            char[] c = s.ToCharArray();
            if (c.Length >= 0)
            {
                
                    if (char.IsLower(c[0]))
                    {
                        c[0] = char.ToUpper(c[0]);
                    }
                
            }
                for (int i = 1; i < c.Length; i++)
                {
                    if (c[i] == ' ')
                    {
                       
                        if (i != c.Length - 1)
                        {
                            c[i + 1] = char.ToUpper(c[i + 1]);
                        }
                        
                            c[i - 1] = char.ToUpper(c[i - 1]);
                        
                       
                        

                    }
                }
                Console.WriteLine(c);
                Console.ReadKey();



            }
        }
    }

