using System;
using System.Collections.Generic;

namespace intToRoman
{
    class Program
    {
        static Dictionary<int, char> intnum = new Dictionary<int, char>()
        {
            {1,     'I' },
            {5,     'V' },
            {10,    'X' },
            {50,    'L' },
            {100,   'C' },
            {500,   'D' },
            {1000,  'M' }
        };
        static void Main(string[] args)
        {
            intToRoman(1554);
            Console.WriteLine(intToRoman(3));
            Console.WriteLine(intToRoman(4));
            Console.WriteLine(intToRoman(9));
            Console.WriteLine(intToRoman(58));
            Console.WriteLine(intToRoman(1994));
        }
        static string intToRoman(int num)
        {
            string str = null;
            for (; num >= 1000;num = num - 1000) str += intnum[1000];
            for (; num >= 500 ; num = num - 500) str += intnum[500];
            for (; num >= 100; num = num - 100) str += intnum[100];
            for (; num >= 50; num = num - 50) str += intnum[50];
            for (; num >= 10; num = num - 10) str += intnum[10];
            for (; num >= 5; num = num - 5) str += intnum[5];
            for (; num >= 1; num = num - 1) str += intnum[1];
            str = str.Replace("VIIII", "IX");
            str = str.Replace("IIII","IV");
            str = str.Replace("LXXXX", "XC");
            str = str.Replace("XXXX", "XL");
            str = str.Replace("DCCCC", "CM");
            str = str.Replace("CCCC", "CD");
            return str;
            
        }
    }
}
