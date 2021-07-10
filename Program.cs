using System;
class Encription 
{
    private static Tuple<string,string> Encript(string str,int n)
    {
        char c;
        int count=0;
        int []store=new int[n];
        int ct=0;
		int pos=0;
		string singleVal="";
		int i;
        for(i=0;i<n;i=i+pos)
        {
            c=str[i];
            for(int j=i;j<n;++j)
            {
                if(str[j]==c)
                {
                    count++;
					pos++;
					if(!singleVal.Contains(str[i]))
					{
						singleVal+=str[i];
					}
                }
            }
            store[ct++]=count;
            count=0;
        }
		for(int k=pos;k<n;k++)
		{
			count++;
			if(!singleVal.Contains(str[k]))
			{
				singleVal+=str[k];
			}
		}
		store[ct++]=count;
		string hexValue = "";
		string Encripted="";
		System.Console.WriteLine(hexValue);
		System.Console.WriteLine();
        for(int z=0;z<ct;z++)
       	{
			if(store[z]>0)
            	hexValue += store[z].ToString("X");
    	}
		string enc=singleVal+hexValue;
		for(int l=enc.Length-1;l>=0;l--)
			 	Encripted+=enc[l];
		int []digit=new int[enc.Length];
		int digitCount=0;
		string []stringItem=new string[enc.Length];
		int stringCount=0;
		for(int m=0;m<Encripted.Length;m++)
		{
			if(Encripted[m]>'0' && Encripted[m]<='9')
			{
				digit[digitCount++]=Encripted[m];
			}
			else
			{
				stringItem[stringCount++]=Encripted[m].ToString();
			}
		}
		int st=0,end=0;
		string finalEncripted="";
		object []final=new object[enc.Length];
		int finCount=0;
		while(st<digitCount && end<stringCount)
		{
			final[finCount++]=singleVal[st++];
			final[finCount++]=store[end++];
		}
		if(final!=null)
		{
			for(int l=final.Length-1;l>=0;l--)
			finalEncripted+=final[l];
		}
		return Tuple.Create(Encripted,finalEncripted);
    }
    public static void Main(String[] args)
    {
        string str="aaabbbcc";
        int len=str.Length;
        var encriptedVal=Encript(str,len);
		if(encriptedVal.Item1!=null &&encriptedVal.Item1!="")
		System.Console.WriteLine("Encrypted value: "+encriptedVal.Item1);
		if(encriptedVal.Item2!=null && encriptedVal.Item2!="")
		System.Console.WriteLine("Second Encrypted Value: "+encriptedVal.Item2);
		System.Console.WriteLine();
    }

}
