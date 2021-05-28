/*public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int ans = 0;
        int pos = s.Length - 1;

        while (pos >= 0 && s[pos] != ' ')
        {
            ans++;
            pos--;
        }

        return ans;
    }
}*/

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        bool word;
        int ans = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
                word = false;
            else
            {
                word = true;
                ans++;
            }

            if (ans > 0 && word == false)
                break;
        }

        return ans;
    }
}

/*public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split()[^1].Length;
    }
}*/