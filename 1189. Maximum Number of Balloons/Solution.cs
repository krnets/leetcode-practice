using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        var word = "balloon";
        var freqA = word.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var freqB = text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var freqC = new Dictionary<char, int>();

        foreach (var c in freqA.Keys)
            if (freqB.ContainsKey(c))
                freqC[c] = freqB[c] / freqA[c];

        return freqC.Count == freqA.Count ? freqC.Values.Min() : 0;
    }
}*/

public class Solution
{
    private string word = "balloon";
    private Dictionary<char, int> freqA;

    public Solution() => freqA = ToDictionary(word);

    private Dictionary<char, int> ToDictionary(string str) =>
        str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

    public int MaxNumberOfBalloons(string text)
    {
        var freqB = ToDictionary(text);
        var freqC = new Dictionary<char, int>();

        foreach (var c in freqA.Keys)
            if (freqB.ContainsKey(c))
                freqC[c] = freqB[c] / freqA[c];

        return freqC.Count == freqA.Count ? freqC.Values.Min() : 0;
    }
}