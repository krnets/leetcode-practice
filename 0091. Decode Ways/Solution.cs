public class Solution
{
    public int NumDecodings(string s)
    {
        int n = s.Length;
        int[] dp = new int[n + 1];

        dp[0] = 1;
        dp[1] = (s[0] == '0') ? 0 : 1;

        for (int i = 2; i <= n; i++)
        {
            int first = int.Parse(s.Substring(i - 1, 1));
            int second = int.Parse(s.Substring(i - 2, 2));

            if (first >= 1 && first <= 9)
            {
                dp[i] += dp[i - 1];
            }

            if (second >= 10 && second <= 26)
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[n];
    }
}