using System;
using System.Collections.Generic;
class ArrangeArray 
{
	
   private static int FindClosest(int []arr)
   {
       int sum=0;
       int res;
       for(int i=0;i<arr.Length;i++)
       {
           sum=sum+arr[i];
       }
       int avg=sum/arr.Length;
       int []store=new int[arr.Length];
       int c=0;
       Dictionary<int,int> map=new Dictionary<int, int>();
       for(int i=0;i<arr.Length;i++)
       {
           if(arr[i]==avg)
                return arr[i];
            res=avg-arr[i];
            map.Add(arr[i],Math.Abs(res));
            store[c++]=Math.Abs(res);
       }
       int min=store[0];
       int minval=0;
       foreach(KeyValuePair<int,int> val in map)
       {
           if(val.Value<min)
           {
                min=val.Value;
                minval=val.Key;
           }
       }
       return minval;
   }
	
   
    public static void Main(String[] args)
    {
		int []arr={7,12,4,19,27,37};
        int res=FindClosest(arr);
        System.Console.WriteLine(res);

    }

}
