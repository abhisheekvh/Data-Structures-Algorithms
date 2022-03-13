using System.Collections.Generic;
using System;
using System.Linq;


class part
{
	internal void partion(int []arr,int n)
    {
		Dictionary<int, int> dt = new Dictionary<int, int>();
		int cnt = 0;
		int max = 0;
		for(int i=0;i<arr.Length;i++)
        {
			if(dt.ContainsKey(arr[i]))
            {
				dt[arr[i]]++;
            }
            else
            {
				dt.Add(arr[i], ++cnt);
				cnt = 0;
				
            }
        }
		
		//var dt1 = dt.GroupBy(x => x.Value).Where(x => x.Count() > 1);

        
       
        Console.WriteLine();
		int j = 0, k = 0;
		foreach (var val in dt.OrderBy(x=>x.Value))
        {
			while(k<val.Value)
            {
				arr[j++] = val.Key;
				k++;
			}
			k= 0;
        }
	}
	private void swap(int []arr,int st,int end)
    {
		int t = arr[st];
		arr[st] = arr[end];
		arr[end] = t;


    }
}
class Partions
{

	public static void Main(String[] args)
	{
		part p = new part();
		int[] arr = new int[] { 2,3,1,3,2};
		
		p.partion(arr,5);

        foreach (var i in arr)
        {
            Console.Write(i + " ");
        }
        //      Console.WriteLine();
        //      Console.WriteLine(res.Item2);

        Console.Read();
	}
}

