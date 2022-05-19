using System;

namespace ReverseLeftWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static public string ReverseLeftWords(string s, int n)
        {
            int i;
            string s1 = null, s2 = null;

            for (i = 0;i<n;i++)
            {
                s1 += s[i];
            }
            for(; i < s.Length; i++)
            {
                s2 += s[i];
            }
            return s2 + s1;
        }
    }

    //public class Solution
    //{
    //    public string ReverseLeftWords(string s, int n)
    //    {
    //        var cut = s.Substring(0, n);
    //        var hold = s.Substring(n, s.Length - n);

    //        return $"{hold}{cut}";
    //    }
    //}
}



