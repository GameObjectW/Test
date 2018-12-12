using System;
using System.Collections.Generic;

namespace Test
{
    public class RomanToIntTest
    {
        public int RomanToInt(String s){
            char[] array = s.ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int final = 0;

            int midmid = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int self = map[array[i]];
                int next = i==array.Length-1?0:map[array[i + 1]];

                if(self < next){
                    self = -self;
                    midmid = - Math.Abs(midmid);
                }
                if(self == next){
                    midmid += self;
                }else{
                    final += (self+midmid);
                    midmid = 0;
                }

            }
            return final;
        }
        //public static void Main(String[] args){
        //    RomanToIntTest r = new RomanToIntTest();
        //    Console.WriteLine(r.RomanToInt("DCXXI"));
        //}
    }
}
