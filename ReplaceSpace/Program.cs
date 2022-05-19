using System;

namespace ReplaceSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReplaceSpace("Hello World!");
        }
        static public string ReplaceSpace(string s)
        {
            s = s.Replace(" ","%20");
            return s;
        }
    }
}
