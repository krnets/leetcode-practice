/*using System.Linq;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int count = 0;

        for (int c = 0; c < strs[0].Length; c++)
        {
            var chArr = new char[strs.Length];

            for (int r = 0; r < strs.Length; r++)
            {
                chArr[r] = strs[r][c];
            }

            if (!chArr.SequenceEqual(chArr.OrderBy(_ => _)))
                count++;
        }

        return count;
    }
}*/

/*public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int count = 0;

        for (int c = 0; c < strs[0].Length; c++)
        {
            char prev = default;

            for (int r = 0; r < strs.Length; r++)
            {
                char ch = strs[r][c];

                if (ch < prev)
                {
                    count++;
                    break;
                }

                prev = ch;
            }
        }

        return count;
    }
}*/

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int count = 0;
        int n = strs.Length;
        int len = strs[0].Length;

        for (int c = 0; c < len; c++)
        {
            int prev = 0;

            for (int r = 0; r < n; r++)
            {
                var ch = strs[r][c];

                if (prev > ch)
                {
                    count++;
                    break;
                }

                prev = ch;
            }
        }

        return count;
    }
}