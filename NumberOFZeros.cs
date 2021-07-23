using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onezero
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            Console.WriteLine("Enter string Values containing 1's and 0's");
            string str = Console.ReadLine();
            Console.WriteLine();
            string s = "";
            int end = str.Length - 1;
            while (str[end] != '1')
                end--;
            for (int i = 0; i <= end; i++)
                s += str[i];
            for (int i = 0; i <= s.Length; i++)
            {
                if (i == s.Length - 1)
                    break;
                if (s[i] == '1')
                    while (s[i + 1] != '1')
                    {
                        count++;
                        i++;
                    }
            }
            Console.WriteLine("Number of 0's between 1's are " + count);
            Console.Read();
        }
    }
}