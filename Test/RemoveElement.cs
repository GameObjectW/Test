using System;
namespace Test
{
    public class RemoveElement
    {
        public int RemoveElementTest(int[] nums, int val)
        {
            if (nums.Length==0||nums.Length==1&&nums[0]==val)
            {
                return 0;
            }
            int length = nums.Length;
            int tailIndex = length - 1;
            while (nums[tailIndex]==val)
            {
                tailIndex--;
            }

            for (int i = 0; i < tailIndex; i++)
            {
                if (nums[i]==val)
                {
                    int mid = nums[tailIndex];
                    nums[tailIndex] = nums[i];
                    nums[i] = mid;

                    while (nums[tailIndex] == val)
                    {
                        tailIndex--;
                    }
                }
            }
            return tailIndex + 1;
        }
    }
}
