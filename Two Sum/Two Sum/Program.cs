/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int len = nums.Length;
        int res = 0;
        int cont = 0;
        int[] result = new int[2];

        while (true)
        {
            res = target - nums[cont];

            for (int i = 0; i < len; i++)
            {
                
                if (res == nums[i] && i != cont) 
                {
                    result[0] = cont;
                    result[1] = i;
                    return result;
                }
            }

            cont++;
            res = 0;
        }
    }

    public static void Main(string[] args)
    {
        int[] nums = { 3, 2, 4 };
        TwoSum(nums,6);
    }
}