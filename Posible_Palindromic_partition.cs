
using System;
using System.Collections.Generic;

public class PrintAllPalindrome
{

	public static void Main(String[] args)
	{
		print(3);
		Console.Read();
	}
	private static void print(int n)
    {
		if(n>0)
        {
			print(n - 1);
			Console.Write(n+ " ");
			
        }
    }

	
	
}

