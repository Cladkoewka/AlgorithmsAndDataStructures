using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Arrays_Hashing
{
    public static class Extensions
    {
        public static string ArrayToString<T>(this T[] arr)
        {
            string res = string.Empty;
            foreach (T item in arr)
            {
                res += $"{item} ";
            }

            return res;
        }
    }
}
