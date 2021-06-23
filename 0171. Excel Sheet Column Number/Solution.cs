/*public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int ans = 0;

        foreach (char c in columnTitle)
        {
            int n = c - 'A' + 1;

            ans *= 26;
            ans += n;
        }

        return ans;
    }
}*/

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int ans = 0;

        for (int i = 0; i < columnTitle.Length; i++)
        {
            char c = columnTitle[i];
            int n = c - 'A' + 1;

            ans *= 26;
            ans += n;
        }

        return ans;
    }
}