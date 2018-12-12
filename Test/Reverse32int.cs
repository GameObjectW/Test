using System;
using System.Collections;
using System.Text;

namespace Test
{
    public class Reverse32int
    {
        public int reverse(int x){
            bool isLessZero = x < 0;
            String num = Math.Abs(x).ToString();
            Char[] numArray = num.ToCharArray();
            Stack stack = new Stack();


            for (int i = 0; i < numArray.Length; i++)
            {
                stack.Push(numArray[i]);
            }

            StringBuilder builder = new StringBuilder();
            while (stack.Count!=0)
            {
                builder.Append(stack.Pop());
            }

            int final = isLessZero ? -Int32.Parse(builder.ToString()):Int32.Parse(builder.ToString());
            Console.WriteLine(final);
            return final > Int32.MaxValue?0:final;
        }

        public int reverse2(int x){
            int rev = 0;
            while (x!=0)
            {
                int mid = x % 10;
                Console.WriteLine(x + "      final");


                if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && mid > 7)){
                    Console.WriteLine(rev+"   *  "+mid);
                    return 0;
                }
                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && mid < -8)){
                    Console.WriteLine(rev + "   *  " + mid);
                    return 0;
                }

                rev = rev * 10 + mid;
                Console.WriteLine(rev);

                x /= 10;
            }
            Console.WriteLine(rev+"    ^^^");
            return rev;
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int initX = x;
            int finalX = 0;
            while (x != 0)
            {
                int mid = x % 10;
                if (finalX > Int32.MaxValue / 10 || (finalX == Int32.MaxValue / 10 && mid > 7))
                {
                    return false;
                }
                x /= 10;
                finalX = finalX * 10 + mid;
            }
            Console.WriteLine(initX == finalX);
            return initX == finalX;
        }


        //public static void Main(String[] args)
        //{
        //    Reverse32int re = new Reverse32int();

        //    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        //    stopwatch.Start(); //  开始监视代码

        //    //re.reverse(-2147483412);
        //    re.reverse2(-2147483412);

        //    re.IsPalindrome(12321);

        //    stopwatch.Stop(); //  停止监视
        //    TimeSpan timeSpan = stopwatch.Elapsed; //  获取总时间

        //    double milliseconds = timeSpan.TotalMilliseconds;  //  毫秒数

        //    Console.WriteLine("{0} MS",milliseconds);

        //}
    }


}
