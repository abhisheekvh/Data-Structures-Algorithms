using System;

namespace recursionPractice
{
    class Program
    {
       private static string common(string []str)
        {
            int size = str.Length;
            if (size == 0)
                return " ";
            if (size == 1)
                return str[0];
             Array.Sort(str);
            int end = Math.Min(str[0].Length, str[size - 1].Length);
            int i = 0;
            while (i < end && str[0][i] == str[size - 1][i])
                i++;
            string prev = str[0].Substring(0, i);
            return prev;

        }
        
        static void Main(string[] args)
        {
            string[] arr = { "glower","gmow","glo" };
            string res = common(arr);
            Console.WriteLine(res);
            
            Console.Read();

        }
    }
}
