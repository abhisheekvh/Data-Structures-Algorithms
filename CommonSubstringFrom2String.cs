using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringManipulation
{
    class Program
    {
        private static void compare(string str1,string str2)
        {
            string st1 = "";
            string st2 = "";
            string[] storest1 = new string[10];
            string[] storest2 = new string[10];
            string[] finalString = new string[str1.Length + str2.Length];
            int finalCount=0;
            int count = 0;
            int count1 = 0;
            for(int j=0;j<str1.Length;j++)
            {
                if (str1[j] != ' ')
                    st1 += str1[j];
                else
                {
                    storest1[count++] = st1;
                    st1 = "";
                }
            }
            storest1[count++] = st1;
            for (int j = 0; j < str2.Length; j++)
            {
                if (str2[j] != ' ')
                    st2 += str2[j];
                else
                {
                    storest2[count1++] = st2;
                    st2 = "";
                }
            }
            storest2[count1++] = st2;
            for(int p=0;p< count;p++)
            {
                for(int q=0;q<count1;q++)
                    if(storest1[p]== storest2[q])
                        finalString[finalCount++] = storest1[p];
            }
            if (finalCount > 0)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Match(s) found!");
                for (int k = 0; k < finalCount; k++)
                    Console.Write(finalString[k] + " ");
            }
            else
                Console.WriteLine("No matches found!");
        }
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.WriteLine("Enter 2 strings with space seperated");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            compare(str1, str2);
            

        }
    }
}