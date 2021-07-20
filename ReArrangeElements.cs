using System;
class GFG
{
    private static void Arrange(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = i; j < arr.Length; j = j + 2)
                {
                    if (arr[i] < arr[j])
                    {
                        int t = arr[j];
                        arr[j] = arr[i];
                        arr[i] = t;
                    }
                }
            }
            else
            {
                for (int j = i; j < arr.Length; j = j + 2)
                {
                    if (arr[i] > arr[j])
                    {
                        int t = arr[j];
                        arr[j] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
        Console.WriteLine("--------------------");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");

        }
    }
   
    public static void Main()
    {
       
        Console.WriteLine("Times??");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter Elements");
        for (int i=0;i<size;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Arrange(arr);
    }
}