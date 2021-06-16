public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        var freq = new int[128];

        foreach (char c in s1)
        {
            freq[c]--;
        }

        int left = 0, right = 0;

        while (right < s2.Length)
        {
            if (++freq[s2[right]] > 0)
            {
                while (--freq[s2[left++]] != 0)
                {
                }
            }

            if ((right - left + 1) == s1.Length)
                return true;

            right++;
        }

        return s1.Length == 0;
    }
}