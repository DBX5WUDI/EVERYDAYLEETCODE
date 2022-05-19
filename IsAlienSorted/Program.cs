using System;
using System.Collections.Generic;

namespace IsAlienSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class Solution
{
    public Dictionary<char, int> Dicorder = new Dictionary<char, int>();
    public bool IsAlienSorted(string[] words, string order)
    {
        char[] myorder = order.ToCharArray();
        for (int i = 0; i < order.Length;i++)
        {
            Dicorder.Add(myorder[i], i);
        }
        for(int i = 0;i < words.Length-1;i++)
        {
            if(words[i].Length<= words[i+1].Length)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (Dicorder[words[i][j]] < Dicorder[words[i + 1][j]]) break;
                    else if (Dicorder[words[i][j]] > Dicorder[words[i + 1][j]]) return false;
                }
            }
            else
            {
                for (int j = 0; j < words[i+1].Length; j++)
                {
                    if (Dicorder[words[i][j]] < Dicorder[words[i + 1][j]]) break;
                    else if (Dicorder[words[i][j]] > Dicorder[words[i + 1][j]]) return false;
                    if (j == words[i + 1].Length - 1) return false;
                }
            }
        }
        return true;
    }
}

