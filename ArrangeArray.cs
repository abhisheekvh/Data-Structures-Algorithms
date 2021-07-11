using System;
using System.Collections.Generic;
class Encription 
{
  
	private static void ArrangeArray(int []arr,int n)
	{
		int count=0;
		for(int i=0;i<n;i++)
			if(arr[i]!=0)
				arr[count++]=arr[i];
			while(count<n)
				arr[count++]=0;
	}
    public static void Main(String[] args)
    {
		int []arr={1,0,0,4,3,9,0,5,0};
		ArrangeArray(arr,arr.Length);
		for(int i=0;i<arr.Length;i++)
		{
			System.Console.Write(arr[i]+" ");
		}
        
    }

}
