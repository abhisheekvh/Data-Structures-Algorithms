using System;
class GFG {
	static String X, Y;
	static int lcs(int i, int j, int count)
	{
		if (i == 0 || j == 0) 
		{
			return count;
		}

		if (X[i - 1] == Y[j - 1]) 
		{
			count = lcs(i - 1, j - 1, count + 1);
		}
		count = Math.Max(count, Math.Max(lcs(i, j - 1, 0),lcs(i - 1, j, 0)));
		return count;
	}
	public static void Main()
	{
		int n, m;
		X = "abcdxyz";
		Y = "xyzabcd";
		n = X.Length;
		m = Y.Length;
		Console.Write(lcs(n, m, 0));
		System.Console.WriteLine();
	}
}

