/*using System.Linq;

public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        return words.Count(w => w.All(allowed.Contains));
    }
}*/

/*public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            bool allMatch = false;

            for (var j = 0; j < word.Length; j++)
            {
                if (!allowed.Contains(word[j]))
                {
                    allMatch = false;
                    break;
                }

                allMatch = true;
            }

            if (allMatch)
                count++;
        }

        return count;
    }
}*/

/*public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;

        for (var i = 0; i < words.Length; i++)
        {
            bool allMatch = false;

            for (var j = 0; j < words[i].Length; j++)
            {
                if (!allowed.Contains(words[i][j]))
                {
                    allMatch = false;
                    break;
                }

                allMatch = true;
            }

            if (allMatch)
                count++;
        }

        return count;
    }
}*/

public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;
        int[] charIndex = new int[26];

        for (int i = 0; i < allowed.Length; i++)
        {
            charIndex[allowed[i] - 'a'] = 1;
        }

        for (int i = 0; i < words.Length; i++)
        {
            bool allMatch = false;

            for (int j = 0; j < words[i].Length; j++)
            {
                int c = words[i][j] - 'a';

                if (charIndex[c] == 0)
                {
                    allMatch = false;
                    break;
                }

                allMatch = true;
            }

            if (allMatch)
                count++;
        }

        return count;
    }
}