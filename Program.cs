using System;

namespace rotate
{
    class Program
    {
        private static void rot(int []arr,int k)
        {
            int place = (arr.Length) - k;
            int[] a1 = new int[place];
            int[] a2 = new int[k];
            int[] tmp = new int[arr.Length];
            int a = 0, b = 0, c = 0;
            k = k % arr.Length;
            for(int i=0;i<arr.Length;i++)
            {
                if(i<place)
                {
                    a1[a] = arr[i];
                    a++;
                }
                else
                {
                    a2[b] = arr[i];
                    b++;
                }
            }
            int l = 0;
            while(c<a2.Length)
            {
                tmp[l++] = a2[c++];
            }
            c = 0;
            while(c<a1.Length)
            {
                tmp[l++] = a1[c++];
            }
            for(int i=0;i<tmp.Length;i++)
            {
                Console.Write(tmp[i]+ " ");
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5};
            rot(arr, 2);
            Console.Read();
        }
    }
}
