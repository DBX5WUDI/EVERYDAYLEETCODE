using System;

namespace DiStringMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            DiStringMatch(s);
        }
        static public int[] DiStringMatch(string s)
        {
            char[] ss = s.ToCharArray();    //转换成单个字符串的数组
            int n = s.Length, permmin = 0, permmax = n;
            int[] perm = new int[n+1];
            string outs = "";
            int i;
            for (i = 0; i< n;i++)
            {
                if (ss[i] == 'I')
                {
                    perm[i] = permmin;
                    permmin++;
                }
                else
                {
                    perm[i] = permmax;
                    permmax--;
                }
                outs += perm[i].ToString() + " ";
            }
            perm[n] = permmax;
            outs += perm[i].ToString() + " ";
            Console.Write(outs);
            return perm;

        }
    }
}
