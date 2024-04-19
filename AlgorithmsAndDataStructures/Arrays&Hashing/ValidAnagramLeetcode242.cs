using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Arrays_Hashing
{
    public class ValidAnagramLeetcode242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] arr = new int[26];

            foreach (char c in s)
            {
                arr[c - 'a']++;
            }
            foreach (char c in t)
            {
                if (arr[c - 'a'] > 0)
                    arr[c - 'a']--;
                else
                    return false;
            }

            return true;


        }

        public static void Test()
        {

            string s11 = "anagram";
            string s12 = "mngraaa";
            string s13 = "fish";

            //Anagrams
            Console.WriteLine($"{s11}, {s12} - {IsAnagram(s11, s12)}");
            //Equal strings
            Console.WriteLine($"{s11}, {s11} - {IsAnagram(s11, s11)}");
            //Not anagrams
            Console.WriteLine($"{s11}, {s13} - {IsAnagram(s11, s13)}");

        }
    }
}
