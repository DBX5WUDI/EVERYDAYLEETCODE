using System;
using System.Collections.Generic;

namespace Optimum_Allocation
{
    class Program
    {
        public struct ser
        {
            public int id;
            public int cpuCount;
            public int memSize;
            public int cpuArch;
            public int SuppOrtNP;
        }
        static void Main(string[] args)
        {
            
            int M = Convert.ToInt32(Console.ReadLine());
            int n;
            int strategy;
            string[] cc;
            string strbuf;
            ser myser = new ser();
            List<ser> serlist = new List<ser>();
            for (int i = 0; i < M; i++)
            {
                strbuf = Console.ReadLine();
                cc = strbuf.Split(" ");
                myser.id = Convert.ToInt32(cc[0]);
                myser.cpuCount = Convert.ToInt32(cc[1]) ;
                myser.memSize = Convert.ToInt32(cc[2]);
                myser.cpuArch = Convert.ToInt32(cc[3]);
                myser.SuppOrtNP = Convert.ToInt32(cc[4]);
                serlist.Add(myser);
            }
            strbuf = Console.ReadLine();
            cc = strbuf.Split(" ");
            n = Convert.ToInt32(cc[0]);
            strategy = Convert.ToInt32(cc[1]);
            myser.cpuCount = Convert.ToInt32(cc[2]);
            myser.memSize = Convert.ToInt32(cc[3]);
            myser.cpuArch = Convert.ToInt32(cc[4]);
            myser.SuppOrtNP = Convert.ToInt32(cc[5]);

            for (int i = 0; i < serlist.Count; i++)
            {
                if (serlist[i].cpuCount < myser.cpuCount)
                {
                    serlist.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < serlist.Count; i++)
            {
                if (serlist[i].memSize < myser.memSize)
                {
                    serlist.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0;i < serlist.Count ; i++ )
            {
                if (serlist[i].cpuArch != myser.cpuArch)
                {
                    serlist.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < serlist.Count; i++)
            {
                if (serlist[i].SuppOrtNP != myser.SuppOrtNP)
                {
                    serlist.RemoveAt(i);
                    i--;
                }
            }

            if (serlist.Count < n)
            {
                string str = null;
                str += Convert.ToString(serlist.Count)+" ";
                Console.WriteLine(str);
            }
            if (strategy == 1)
            {
                serlist.Sort(delegate(ser ser1,ser ser2)
                {
                    return ser1.cpuCount.CompareTo(ser1.cpuCount);
                }
                );
            }
            else if (strategy == 2)
            {
                serlist.Sort(delegate (ser ser1, ser ser2)
                {
                    return ser1.memSize.CompareTo(ser1.memSize);
                }
                );
            }
        }
    }
}
