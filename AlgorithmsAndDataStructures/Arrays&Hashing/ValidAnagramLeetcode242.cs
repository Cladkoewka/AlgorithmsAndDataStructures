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
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (!dictionary.ContainsKey(c))
                    dictionary[c] = 0;
                

                dictionary[c]++;
            }

            foreach (char c in t)
            {
                if (!dictionary.ContainsKey(c))
                    dictionary[c] = 0;

                dictionary[c]--;
            }


            foreach(var pair in dictionary)
            {
                if (pair.Value != 0)
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
