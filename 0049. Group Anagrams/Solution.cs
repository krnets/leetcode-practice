/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var list = strs.ToList();
        var result = new List<IList<string>>();

        while (list.Count > 0)
        {
            var first = list.First().OrderBy(c => c);
            IList<string> tempList = list.Where(x => x.OrderBy(c => c).SequenceEqual(first)).ToList();

            result.Add(tempList);
            list.RemoveAll(x => tempList.Contains(x));
        }

        return result;
    }
}*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return new List<IList<string>>();
        }

        var map = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] charCount = new char[26];

            foreach (char c in str)
            {
                charCount[c - 'a']++;
            }

            var keyStr = new string(charCount);

            if (!map.ContainsKey(keyStr))
            {
                map.Add(keyStr, new List<string>());
            }

            map[keyStr].Add(str);
        }

        return new List<IList<string>>(map.Values);
    }
}