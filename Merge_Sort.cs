using System;

namespace MergeSort
{
    class Program
    {
        private static void Merge(int []arr,int low,int middle,int high)
        {
            int i = low;
            int j = middle + 1;
            int[] store = new int[arr.Length];
            int k=low;
            while(i<=middle && j<=high)
            {
                if(arr[i]<arr[j])
                {
                    store[k] = arr[i++];
                }
                else
                {
                    store[k] = arr[j++];
                }
                k++;
            }
            while (i <= middle)
                store[k++] = arr[i++];
            while (j <= high)
                store[k++] = arr[j++];
            for(int l=low;l<=high;l++)
            {
                arr[l] = store[l];
            }

        }
        private static void MergePartition(int []arr,int low,int high)
        {
            int middle = (low+high)/2;
            if(low<high)
            {
                MergePartition(arr, low, middle);
                MergePartition(arr, middle + 1, high);
                Merge(arr, low, middle, high);

            }


        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 2, 23, 1, 8, 6 };
            MergePartition(arr, 0, arr.Length - 1);
            for(int i=0;i<arr.Length;i++)
                Console.Write(arr[i]+ " ");
            Console.Read();

        }
    }
}
