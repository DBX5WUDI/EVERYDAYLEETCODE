using System;
using System.Collections.Generic;
namespace RomanToInt
{
    class Program
    {
        static Dictionary<Char, int> romannum = new Dictionary<Char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        
        static public int RomanToInt(string s)
        {
            int sum=0;
            char[] ss = s.ToCharArray();
            for(int i=0; i<s.Length-1; i++)
            {
                if (romannum[ss[i]] >= romannum[ss[i + 1]]) sum += romannum[ss[i]];
                else sum -= romannum[ss[i]];
            }
            sum += romannum[ss[s.Length - 1]];
            return sum;
        }
    }
}
