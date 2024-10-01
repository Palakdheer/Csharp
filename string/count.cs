using System;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "my name is palak";
            char[] c = s1.ToCharArray();
            Console.WriteLine("Original String: " + s1);

            int vowelCount = 0;
            int ConstCount = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (char.IsLetter(c[i]))
                {
                   
                    if (c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U' ||
                        c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                    {
                        vowelCount++;  
                    }
                    else
                    {
                        ConstCount++;
                    }
                }
            }

           
            Console.WriteLine("Total number of vowels: " + vowelCount);
            Console.WriteLine("Total number of Consonents : " + ConstCount);
            Console.ReadLine();
        }
    }
}
