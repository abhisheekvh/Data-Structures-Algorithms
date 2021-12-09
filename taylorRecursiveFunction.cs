using System;

namespace recursion
{
    class Program
    {
        public static double p = 1, f = 1;
        public static double r;
        private static double Taylor(int m,int n)
        {
            
            
            if (n == 0)
                return (1);
            else
            {
                r = Taylor(m, n - 1);
                p = p * m;
                f = f * n;
                return r + (p / f);
            }
        }
        static void Main(string[] args)
        {
            double res = Taylor(1,10);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
