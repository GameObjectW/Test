using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixTest(String[] strs) {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            foreach (String str in strs)
            {
                if (str=="")
                {
                    return "";
                }
            }

            StringBuilder sb = new StringBuilder();

            int currentIndex = -1;
            String[] strArray = strs;

            char maxNumFirstChar = strs[0][0];
            while (true)
            {
                currentIndex++;
                if (strArray[0].Length == currentIndex)
                {
                    return sb.ToString();
                }
                maxNumFirstChar = strs[0][currentIndex];
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i].Length == currentIndex||strArray[i][currentIndex]!= maxNumFirstChar)
                    {
                        return sb.ToString();
                    }
                }
                sb.Append(maxNumFirstChar);
            }
        }
        //public static void Main(String[] args){
        //    LongestCommonPrefix r = new LongestCommonPrefix();
        //    Console.WriteLine(r.LongestCommonPrefixTest(new string[] {"flow", "fl", "flabc"}));
        //}
    }

}
