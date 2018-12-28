using System;
namespace Test
{
    public class MaxSubArray
    {
        public int MaxSubArrayTest(int[] nums)
        {
            int sum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currentSum>0)
                {
                    currentSum += nums[i];
                }
                else {
                    currentSum = nums[i];
                }
                if (currentSum>sum)
                {
                    sum = currentSum;
                }
            }
            return sum;
        }
    }
}
