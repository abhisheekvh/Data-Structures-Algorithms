using System;
using System.Collections.Generic;
using System.Linq;

namespace DictBalanced
{
    class Program
    {
        private static bool balanced(string str)
        {
            Dictionary<char, char> dt = new Dictionary<char, char> 
            {

                {'(',')' },
                {'{','}' },
                {'[',']' }
            
            };
            Stack<char> st = new Stack<char>();
            try
            {
                foreach (char symbol in str)
                {


                    if (dt.Keys.Contains(symbol))
                    {
                        st.Push(symbol);
                    }
                    else if (dt.Values.Contains(symbol))
                    {
                        if (symbol == dt[st.First()])
                        {
                            st.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        continue;
                }
                return st.Count() == 0 ? true : false;
            }catch(Exception ex)
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            string str = "[[{{}}]]";
            if(balanced(str))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("No");
            Console.Read();
        }
    }
}
