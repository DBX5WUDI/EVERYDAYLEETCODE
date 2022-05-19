using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static public int MissingNumber(int[] nums)
        {
            if (nums.Length == 1 && nums[0] == 1) return 0;
            if (nums.Length == 1 && nums[0] == 0) return 1;
            for (int i = 0;i<nums.Length;i++)
            {
                if (i != nums[i]) return i;
            }
            return nums.Length;
        }
    }
}
