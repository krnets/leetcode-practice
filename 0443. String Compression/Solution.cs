/*
public class Solution
{
    public int Compress(char[] chars)
    {
        char prev = chars[0];
        int count = 1;
        int len = 0;

        for (int i = 1;; i++)
        {
            if (i < chars.Length && chars[i] == prev)
                count++;
            else
            {
                chars[len++] = prev;

                if (count > 1)
                    foreach (char c in count.ToString())
                        chars[len++] = c;

                if (i >= chars.Length)
                    break;

                prev = chars[i];
                count = 1;
            }
        }

        return len;
    }
}
*/

public class Solution
{
    public int Compress(char[] chars)
    {
        int len = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            int count = 1;
            chars[len] = chars[i];

            while (i < chars.Length - 1)
            {
                if (chars[i] == chars[i + 1])
                {
                    count++;
                    i++;
                    continue;
                }

                break;
            }

            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    len++;
                    chars[len] = c;
                }
            }

            len++;
        }

        return len;
    }
}