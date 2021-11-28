using System;
using System.Collections.Generic;
using System.Linq;

namespace validparath
{
    
    class Program
    {
        public static string store = "";
        public static string validate(string str)
        {
            Dictionary<char, char> Dbr = new Dictionary<char, char>()
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
                {'<','>' }
            };
            Stack<char> st = new Stack<char>();
            foreach(char c in str)
            {
                if(Dbr.Keys.Contains(c))
                {
                    st.Push(c);
                }
                else
                {
                    if(Dbr.Values.Contains(c))
                    {
                        if (st.Count > 0 &&(c == Dbr[st.First()]) )
                        {
                            store += st.First();
                            store += c;
                            st.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return store;
        }

        static void Main(string[] args)
        {
            string str = "{[]}";
            string s = validate(str);
            
            if(s!="")
            {
                Console.WriteLine(s);
            }
            
            Console.Read();
        }
    }
}
