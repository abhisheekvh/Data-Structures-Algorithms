using System;
class GFG
{
    static void RemovePalindrom(String str)
    {
        string[] store = new string[str.Length];
        int c = 0;
        string s = "";
        string emp = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
                s += str[i];
            else
            {
                int l = 0;
                int h = s.Length - 1;
                while (h > l)
                {
                    if (s[l++] != s[h--])
                    {
                        emp += s;
                        s = "";
                        break;
                    }
                }
                if (emp != "")
                    store[c++] = emp;
                emp = "";
                s = "";
            }
        }
        emp = "";
        int start = 0;
        int end = s.Length - 1; ;
        while (end > start)
        {
            if (s[start++] != s[end--])
            {
                emp += s;
                s = "";
                break;
            }
        }
        if (emp != "")
            store[c++] = emp;
        for (int i = 0; i < c; i++)
            Console.Write(store[i] + " ");
    }
    public static void Main()
    {
        String str = "this is deed gadag";
        RemovePalindrom(str);
        
    }
}

