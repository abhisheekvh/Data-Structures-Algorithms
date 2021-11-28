using System;

namespace stringPermu_backtracking
{
    class Program
    {
        private static void Permute(string str,int l,int r)
        {
            if(l==r)
                Console.WriteLine(str);
            else
            {
                for(int i=l;i<=r;i++)
                {
                     str = swap(str, l, i);
                    Permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        private static string swap(string str,int i,int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;

        }
        static void Main(string[] args)
        {
            string str = "abc";
            Permute(str, 0, str.Length - 1);
            Console.Read();
        }
    }
}
