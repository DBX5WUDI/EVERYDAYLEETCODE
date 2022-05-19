using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static public int Search(int[] nums, int target)
        {
            int j = 0;
            for(int i = 0;i<nums.Length;i++)
            {
                if (nums[i] == target)
                {
                    j++;
                    if (i == nums.Length-1) return j;//关键性一句
                    if (nums[i+1] != target) return j;
                }
            }
            return 0;
        }
    }
}
