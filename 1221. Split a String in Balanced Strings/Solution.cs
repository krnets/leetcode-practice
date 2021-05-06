/*public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int splits = 0;
        int balance = 0;

        foreach (char c in s)
        {
            if (c == 'R')
                balance++;
            else if (c == 'L')
                balance--;

            if (balance == 0)
                splits++;
        }

        return splits;
    }
}*/

/*public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int splits = 0;
        int balance = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == 'R')
                balance++;
            else if (c == 'L')
                balance--;

            if (balance == 0)
                splits++;
        }

        return splits;
    }
}*/

public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int balance = 0;
        int l = 0;
        int r = 0;

        foreach (var c in s)
        {
            if (c == 'L') l++;
            else if (c == 'R') r++;

            if (l == r)
            {
                l = 0;
                r = 0;
                balance++;
            }
        }

        return balance;
    }
}