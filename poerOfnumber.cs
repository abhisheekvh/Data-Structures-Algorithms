using System;

namespace recursion
{
    class Program
    {
        private static int power(int m,int n)
        {
            if (n == 0)
                return 1;
            else
                if(n%2==0)
                    return power(m * m, n / 2);
                else
                    return m * power(m*m, (n - 1) / 2);
        }
        static void Main(string[] args)
        {
            int res = power(2, 9);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
