/*using System.Collections.Generic;

public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int[] result = new int[s.Length + 1];
        var queue = new LinkedList<int>();

        for (var i = 0; i <= s.Length; i++)
            queue.AddLast(i);

        for (int i = 0; i < result.Length; i++)
        {
            if (i == s.Length)
            {
                result[i] = queue.Last.Value;
                queue.RemoveLast();
            }
            else if (s[i] == 'I')
            {
                result[i] = queue.First.Value;
                queue.RemoveFirst();
            }
            else
            {
                result[i] = queue.Last.Value;
                queue.RemoveLast();
            }
        }

        return result;
    }
}*/

/*public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int n = s.Length;
        var result = new int[n + 1];
        int low = 0;
        int high = n;

        for (int i = 0; i < n; i++)
        {
            result[i] = s[i] switch
            {
                'I' => low++,
                'D' => high--,
                _ => result[i]
            };
        }

        result[n] = high;

        return result;
    }
}*/

/*public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int n = s.Length;
        var result = new int[n + 1];
        int low = 0;
        int high = n;

        for (int i = 0; i < n; i++)
        {
            result[i] = s[i] is 'I' ? low++ : s[i] is 'D' ? high-- : result[i];
        }

        result[n] = high;

        return result;
    }
}*/

public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int n = s.Length;
        var result = new int[n + 1];
        int low = 0;
        int high = n;

        for (int i = 0; i < n; i++)
        {
            result[i] = s[i] == 'I' ? low++ : s[i] == 'D' ? high-- : result[i];
        }

        result[n] = high;

        return result;
    }
}

/*public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int n = s.Length;
        var result = new int[n + 1];
        int low = 0;
        int high = n;

        for (int i = 0; i < n; i++)
        {
            result[i] = s[i] == 'I' ? low++ : high--;
        }

        result[n] = high;

        return result;
    }
}*/