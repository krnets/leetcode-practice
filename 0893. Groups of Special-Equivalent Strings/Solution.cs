using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
public class Solution
{
    public int NumSpecialEquivGroups(string[] words)
    {
        var set = new HashSet<string>();

        foreach (var word in words)
        {
            int[] odd = new int[26];
            int[] even = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                int c = word[i] - 'a';

                if (i % 2 == 0)
                    even[c]++;
                else odd[c]++;
            }

            var key = string.Concat(odd.Concat(even));
            set.Add(key);
        }

        return set.Count;
    }
}*/
/*
public class Solution
{
    public int NumSpecialEquivGroups(string[] words)
    {
        var set = new HashSet<string>();

        foreach (var word in words)
        {
            int[] odd = new int[26];
            int[] even = new int[26];

            for (int i = 0; i < word.Length; i += 2)
            {
                int c = word[i] - 'a';
                even[c]++;
            }

            for (int i = 1; i < word.Length; i += 2)
            {
                int c = word[i] - 'a';
                odd[c]++;
            }

            var key = string.Concat(odd.Concat(even));
            set.Add(key);
        }

        return set.Count;
    }
}*/

/*public class Solution
{
    public int NumSpecialEquivGroups(string[] words)
    {
        var set = new HashSet<string>();

        foreach (var word in words)
        {
            int[] odd = new int[26];
            int[] even = new int[26];

            for (int i = 0; i < word.Length; i += 2)
            {
                int c = word[i] - 'a';
                even[c]++;
            }

            for (int i = 1; i < word.Length; i += 2)
            {
                int c = word[i] - 'a';
                odd[c]++;
            }

            var key = string.Concat(odd.Concat(even));
            set.Add(key);
        }

        return set.Count;
    }
}*/

public class Solution
{
    public int NumSpecialEquivGroups(string[] words)
    {
        var set = new HashSet<string>();
        var even = new StringBuilder();
        var odd = new StringBuilder();

        foreach (var word in words)
        {
            even.Clear();
            odd.Clear();

            for (int i = 0; i < word.Length; i += 2) even.Append(word[i]);
            for (int i = 1; i < word.Length; i += 2) odd.Append(word[i]);

            var evArr = even.ToString().ToCharArray();
            var oddArr = odd.ToString().ToCharArray();

            Array.Sort(evArr);
            Array.Sort(oddArr);

            var key = new string(evArr) + new string(oddArr);
            set.Add(key);
        }

        return set.Count;
    }
}