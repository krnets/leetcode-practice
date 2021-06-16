public class Solution
{
    public string MinWindow(string s, string t)
    {
        var arr = new int[128];

        foreach (char c in t)
            arr[c]++;

        var result = string.Empty;
        int left = 0, right = 0, countMatchingChars = 0;
        int minLen = int.MaxValue;

        while (right < s.Length)
        {
            var rChar = s[right];

            if (--arr[rChar] >= 0)
                countMatchingChars++;

            while (countMatchingChars == t.Length)
            {
                int curWindow = right - left + 1;

                if (curWindow < minLen)
                {
                    minLen = curWindow;
                    result = s.Substring(left, minLen);
                }

                var lChar = s[left];

                if (++arr[lChar] > 0)
                    countMatchingChars--;

                left++;
            }

            right++;
        }

        return result;
    }
}