using System;
using System.Collections;


public class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = new int[] { 0,0,0,0,0 };
        int k = RemoveDuplicates(nums);
        Console.WriteLine(k);
    }
    public static int RemoveDuplicates(int[] nums)
    {
        int k = nums.Count();
        Console.WriteLine(k);
        int p1;
        int dupCount = 0;
        for (int i = 0; i < nums.Count() - 1; i++)
        {
            dupCount = 0;
            p1 = nums[i];
            if (p1 != Int32.MaxValue)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (nums[j] == p1)
                    {
                        dupCount++;
                    }
                    if (dupCount > 1)
                    {
                        nums[j] = Int32.MaxValue;
                        k--;
                        dupCount--;
                        Console.WriteLine($"nums: {j} removed. P1 = {p1}, k = {k}");
                    }
                }
            }

        }
        Array.Sort(nums);
        foreach (int n in nums)
        {
            Console.WriteLine($"nums: {n}");
        }
        return k;
    }
}