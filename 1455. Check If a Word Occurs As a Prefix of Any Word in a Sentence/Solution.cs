/*public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var split = sentence.Split();

        for (int i = 0; i < split.Length; i++)
            if (split[i].StartsWith(searchWord))
                return i + 1;

        return -1;
    }
}*/

public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var split = sentence.Split();
        int len = searchWord.Length;

        for (int i = 0; i < split.Length; i++)
        {
            var word = split[i];

            if (word.Length >= len && word[..len] == searchWord)
                return i + 1;
        }

        return -1;
    }
}