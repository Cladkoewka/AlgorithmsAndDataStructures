using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Two_Pointers
{
    public class ValidPalindromeLeetcode125
    {
        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; j > i; )
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (char.ToLower(s[i++]) != char.ToLower(s[j--]))
                    return false;
                
            }

            return true;
        }

        public static void Test()
        {

            string s1 = "A man, a plan, a canal: Panama";
            Console.WriteLine($"{s1} - {IsPalindrome(s1)}");

            string s2 = "race a car";
            Console.WriteLine($"{s2} - {IsPalindrome(s2)}");

            string s3 = " ";
            Console.WriteLine($"{s3} - {IsPalindrome(s3)}");

        }
    }
}
