using System;
using System.Collections.Generic;
class ArrangeArray 
{
    public static void Main(String[] args)
    {
		string str="a11b6c55";
		int len=str.Length;
		string []num=new string[len];
		int c=0;
		string n="";
		string []charStore=new string[len];
		int charCount=0;
		for(int i=0;i<len;i++)
		{
			if(str[i]>='0' && str[i]<='9')
			{
				n+=str[i]-'0';
			}
			else
			{
				charStore[charCount++]=str[i].ToString();
				if(n!="")
				{
					num[c++]=n;
				}
				n="";
			}
		}
		num[c++]=n;
		int p=0,q=0;
		int z=0;
		for(p=0;p<charStore.Length && p<num.Length;p++)
		{
			int dig= Convert.ToInt32(num[p]);
			for(q=0;q<dig;q++)
			{
				System.Console.Write(charStore[z]);
			}
			z++;
		}
		System.Console.WriteLine();
    }

}
