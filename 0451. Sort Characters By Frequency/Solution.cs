/*using System.Linq;

public class Solution
{
    public string FrequencySort(string s)
    {
        var charCount = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        return string.Concat(s.OrderBy(c => c).OrderByDescending(c => charCount[c]));
    }
}*/

public class Solution
{
    public string FrequencySort(string s)
    {
        var charCount = new int[128];
        char[] ans = new char[s.Length];

        foreach (char c in s) charCount[c]++;

        int i = 0;

        while (i < s.Length)
        {
            int max = 0;
            int maxIndex = 0;

            for (int j = 0; j < 128; j++)
            {
                if (charCount[j] > max)
                {
                    max = charCount[j];
                    maxIndex = j;
                }
            }

            while (charCount[maxIndex] > 0)
            {
                ans[i] = (char) maxIndex;
                charCount[maxIndex]--;
                i++;
            }
        }

        return new string(ans);
    }
}