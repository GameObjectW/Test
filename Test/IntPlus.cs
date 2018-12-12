using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// 给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。
    /// 你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。
    /// </summary>
    public class IntPlus
    {
        int[] numArray = { 2, 7, 11, 15 };
        int target = 9;

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();      //使用hash表来辅助判断

            for (int i = 0; i < nums.Length; i++)
            {
                int dicKey = target - nums[i];                          //得出匹配的值
                if (map.ContainsKey(dicKey))
                {
                    return new int[] { i, map[dicKey] };                //在map中判断是否存在，存在则取出起index并输出
                }else if(!map.ContainsKey(nums[i]))
                    map[nums[i]] = i;
            }
            return null;
        }

        //public static void Main(string[] args)
        //{
        //    IntPlus mc = new IntPlus();
        //    foreach (var item in mc.TwoSum(mc.numArray, mc.target))
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine();
        //}
    }
}
