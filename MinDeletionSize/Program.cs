using System;
using System.Collections.Generic;
namespace MinDeletionSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string[] str = { "zyx", "wvu", "tsr" };
            num = MinDeletionSize(str); 
            Console.WriteLine("Hello World!");
        }
        static public int MinDeletionSize(string[] strs)
        {
            int n = strs.Length;
            int m = strs[0].Length;
            int num=0;
            char[][] c = new char[n][];
            for (int i = 0;i < n;i++)
            {
               c[i] = strs[i].ToCharArray();
            }
            for(int j =0; j < m; j++)
            {
                for(int i=0;i<n-1;i++)
                {
                    if (c[i][j] > c[i + 1][j])
                    {
                      num++;
                      break;
                    }
                }
            }
            return num;
        }
    }
}
