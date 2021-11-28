
using System;

public class GFG
{

	static string longestCommonPrefix(String[] a)
	{
		int size = a.Length;

	
		if (size == 0)
			return "";

		if (size == 1)
			return a[0];

		Array.Sort(a);


		int end = Math.Min(a[0].Length,
							a[size - 1].Length);

		int i = 0;
		char a2 = a[1][2];
		char a3 = a[size - 1][2];
		
		while (i < end && a[0][i] == a[size - 1][i])
			i++;

		string pre = a[0].Substring(0, i);
		return pre;
	}

	public static void Main()
	{

		string[] input = {"fower", "flow",
								"flight"};

		Console.WriteLine("The longest Common"
							+ " Prefix is : "
				+ longestCommonPrefix(input));
	}
}

