using System.Text;

/*public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int n = s.Length;
        int half = n / 2;

        for (int i = 1; i <= half; i++)
        {
            if (n % i == 0)
            {
                if ($"{new StringBuilder().Insert(0, s[..i], n / i)}" == s)
                    return true;
            }
        }

        return false;
    }
}*/

/*public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int n = s.Length;
        int half = n / 2;

        for (int i = 1; i <= half; i++)
        {
            if (n % i == 0)
            {
                int k = 0;

                while (i + k < n && s[k] == s[i + k])
                    k++;

                if (k + i == n)
                    return true;
            }
        }

        return false;
    }
}*/

/*public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int n = s.Length;
        int half = n / 2 + 1;

        for (int i = 1; i < half; i++)
        {
            if (n % i == 0)
            {
                int k = 0;

                while (i + k < n && s[k] == s[i + k])
                    k++;

                if (k + i == n)
                    return true;
            }
        }

        return false;
    }
}*/

public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int n = s.Length;
        int half = n / 2;

        for (int i = half; i > 0; i--)
        {
            if (n % i == 0)
            {
                int k = 0;

                while (i + k < n && s[k] == s[i + k])
                    k++;

                if (k + i == n)
                    return true;
            }
        }

        return false;
    }
}