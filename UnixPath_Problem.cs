using System;
using System.Collections.Generic;

namespace Unixpath
{
    public class Simplify
    {
        public void FinalPath(string str)
        {
            string s = string.Empty;
            int cnt = 0;
            Stack<string> st = new Stack<string>();
            Stack<string> rev = new Stack<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/')
                    continue;
                else if (str[i] != '.')
                {
                    s += str[i];
                }
                if (i < str.Length - 1 && str[i + 1] == '/' && str[i] != '.')
                {
                    st.Push(s);
                    s = string.Empty; ;
                }
                if (i == str.Length - 1 && str[i] != '.' && str[i] != '/')
                {
                    st.Push(s);
                    s = string.Empty;
                }
                if (str[i] == '.')
                {
                    cnt++;
                    if (cnt > 1)
                    {
                        while (cnt != 0)
                        {
                            if (st.Count > 0)
                            {
                                st.Pop();
                                cnt--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (str[i + 1] == '/')
                    {
                        cnt = 0;
                        continue;
                    }
                }
            }
            if (st.Count > 0)
            {
                while (st.Count != 0)
                {
                    rev.Push(st.Pop());
                }
                foreach (var el in rev)
                {
                    Console.Write("/" + el);
                }
            }
            else
            {
                Console.WriteLine("/");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Simplify sp = new Simplify();
            string str = "/a//b//c//////d";
            sp.FinalPath(str);
            Console.Read();
        }
    }
}
