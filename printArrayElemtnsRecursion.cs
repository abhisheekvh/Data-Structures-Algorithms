using System;

namespace recursionPractice
{
    class Program
    {
        public static int i = 0;
        private static void sum(int []arr,int size)
        {

            if(arr.Length-1==size)
                Console.Write(arr[arr.Length-1]+" ");  //base condition
            else
            {
                Console.Write(arr[i++]+ " ");
                sum(arr, i);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6 };
            sum(arr,0);
            Console.Read();

        }
    }
}
