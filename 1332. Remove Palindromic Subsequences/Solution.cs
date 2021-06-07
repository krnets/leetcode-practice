/*public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        int n = s.Length;
        int half = n / 2;

        for (int i = 0; i < half; i++)
        {
            if (s[i] != s[n - i - 1])
                return 2;
        }

        return 1;
    }
}*/

public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else return 2;
        }

        return 1;
    }
}