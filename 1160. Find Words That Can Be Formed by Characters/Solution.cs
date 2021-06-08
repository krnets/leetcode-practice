using System;
using System.Linq;

/*public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        int lengthSum = 0;

        foreach (var word in words)
        {
            var charsList = chars.ToList();

            for (int j = 0; j < word.Length; j++)
            {
                char c = word[j];

                if (!charsList.Contains(c))
                    break;

                charsList.Remove(c);

                if ((j + 1) == word.Length)
                    lengthSum += word.Length;
            }
        }

        return lengthSum;
    }
}*/


public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        int lengthSum = 0;
        var charsCount = new int[26];

        foreach (var c in chars)
            charsCount[c - 'a']++;

        foreach (var word in words)
        {
            var arrCopy = new int[26];
            Array.Copy(charsCount, arrCopy, 26);

            for (int j = 0; j < word.Length; j++)
            {
                var c = word[j] - 'a';

                if (arrCopy[c] == 0)
                    break;

                arrCopy[c]--;

                if ((j + 1) == word.Length)
                    lengthSum += word.Length;
            }
        }

        return lengthSum;
    }
}