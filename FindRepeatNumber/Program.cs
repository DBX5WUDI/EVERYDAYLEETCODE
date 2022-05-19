using System;

namespace FindRepeatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static public int FindRepeatNumber(int[] nums)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[nums[i]]++;
                if (a[nums[i]] > 1) return nums[i];
            }
            return 0;
        }
    }

}
