using System;
using System.Collections.Generic;
namespace Algorithms
{
    class Program
    {
        private static string CommonPrefix(string[] str,int time)
        {
            if(str.Length==0)
                return string.Empty;
            if(str.Length==1)
                return str[0];
            int i=0;
            string pref=string.Empty;
            Array.Sort(str);

            int min=Math.Min(str[0].Length,str[time-1].Length);
            while(i<min && str[0][i]==str[time-1][i])
                i++;
            pref+=str[0].Substring(0,i);
            return pref;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input the size");
            int size=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Input strings Elements");
            string []str=new string[size];
            for(int i=0;i<size;++i)
                str[i]=Console.ReadLine();
            string result=CommonPrefix(str,size);
            System.Console.WriteLine( "----------------------------------");
            System.Console.WriteLine("Longest Common Prefix is :"+result);
            
        }
    }
}
