using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Stack
{
    public class ValidParenthesesLeetcode20
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }

            return stack.Count == 0;
        }


        public static void Test()
        {
            string s1 = "()";

            Console.WriteLine($"{s1} - {IsValid(s1)}");

            string s2 = "()[]{}";

            Console.WriteLine($"{s2} - {IsValid(s2)}");

            string s3 = "(]";

            Console.WriteLine($"{s3} - {IsValid(s3)}");
        }
    }
}
