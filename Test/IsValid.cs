using System;
using System.Collections.Generic;

namespace Test
{
    public class IsValid
    {

        public bool isValid(String s) {
            if (s=="")
            {
                return true;
            }
            Stack<Char> stack = new Stack<Char>();

            foreach (char item in s)
            {
                if (item=='('||item=='{'||item=='[')
                {
                    stack.Push(item);
                }else if(item == ')'||item == ']'||item=='}') {

                    if (stack.Count==0)
                    {
                        return false;
                    }
                    char pre = stack.Pop();
                    if (item==')'&&pre=='('||item==']'&&pre=='['||item=='}'&&pre=='{')
                    {
                        continue;
                    }
                    return false;
                }
            }

            return stack.Count == 0;
        }

        //public static void Main(String[] args)
        //{
        //    IsValid isValid = new IsValid();
        //    Console.WriteLine("Is Successful : " + isValid.isValid("{}[](){}"));
        //}
    }

}
