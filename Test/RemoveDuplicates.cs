using System;
namespace Test
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicatesTest(int[] nums)
        {
            if (nums.Length==0)
            {
                return 0;
            }

            int length = 0;
            for (int i = 0,j = 1; j < nums.Length; j++)  
            {
                if (nums[i]!=nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                    length = i;
                }
            }

            return length+1;
        }

        public static void Main(String[] args) {
            RemoveDuplicates r = new RemoveDuplicates();
            int[] demo = new int[] { 1,1,2 };
            Console.WriteLine(r.RemoveDuplicatesTest(demo));

            foreach (int item in demo)
            {
                Console.Write(item + "  ");
            }
        }
    }
}
