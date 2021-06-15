using System.Linq;

/*public class Solution
{
    public int MaxRepeating(string sequence, string word)
    {
        int k = 1;

        while (sequence.Contains(string.Concat(Enumerable.Repeat(word, k))))
        {
            k++;
        }

        return k - 1;
    }
}*/

public class Solution
{
    public int MaxRepeating(string sequence, string word)
    {
        var wordExpand = word;
        int k = 0;

        while (sequence.Contains(wordExpand))
        {
            wordExpand += word;
            k++;
        }

        return k;
    }
}