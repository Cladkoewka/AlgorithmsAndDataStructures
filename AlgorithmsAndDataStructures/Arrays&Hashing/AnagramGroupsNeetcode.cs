namespace AlgorithmsAndDataStructures.Arrays_Hashing;

public class AnagramGroupsNeetcode
{

    public static void Test()
    {
        List<string> input = new List<string>(){"act", "pots", "tops", "cat", "stop", "hat"};
        
        var res = GroupAnagrams(input.ToArray());
        foreach (var list in res)
        {
            Console.WriteLine(list.ToArray().ArrayToString());
        }
    }
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var symbolsCount = new int[26];
            foreach (var c in str)
                symbolsCount[c - 'a']++;

            var key = string.Join('_', symbolsCount);

            if (!dictionary.ContainsKey(key))
                dictionary[key] = new List<string>();

            dictionary[key].Add(str);
        }

        return new List<List<string>>(dictionary.Values);
    }
}