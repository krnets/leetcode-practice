using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];

            for (int j = 0; j < words.Length; j++)
            {
                var cmp = words[j];

                if (i != j && word.Length < cmp.Length && cmp.Contains(word))
                    set.Add(word);
            }
        }

        return set.ToList();
    }
}