/*public class Solution
{
    public int CountSubstrings(string s, string t)
    {
        int m = s.Length;
        int n = t.Length;

        var sChars = s.ToCharArray();
        var tChars = t.ToCharArray();

        var same = new int[m + 1, n + 1];
        var diff = new int[m + 1, n + 1];

        int ans = 0;

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (sChars[i - 1] == tChars[j - 1])
                {
                    same[i, j] = same[i - 1, j - 1] + 1;
                    diff[i, j] = diff[i - 1, j - 1];
                }
                else diff[i, j] = same[i - 1, j - 1] + 1;

                ans += diff[i, j];
            }
        }

        return ans;
    }
}*/

using System;
using System.Linq;

public class Solution
{
    public int CountSubstrings(string s, string t)
    {
        int m = s.Length;
        int n = t.Length;

        var same = new int[m + 1, n + 1];
        var diff = new int[m + 1, n + 1];

        int ans = 0;

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s[i - 1] == t[j - 1])
                {
                    same[i, j] = same[i - 1, j - 1] + 1;
                    diff[i, j] = diff[i - 1, j - 1];
                }
                else diff[i, j] = same[i - 1, j - 1] + 1;

                ans += diff[i, j];
            }
        }

        Console.WriteLine(new string('-', 10));
        Console.WriteLine("same");
        Console.WriteLine(new string('-', 10));

        for (int i = 0; i < same.GetLength(0); i++)
        {
            if (i == 0)
            {
                Console.WriteLine("  |   " + string.Join(" ", t.Select(c => c)));
                Console.Write("  | ");
            }

            if (i > 0) Console.Write(s[i - 1] + " | ");

            for (int j = 0; j < same.GetLength(1); j++)
            {
                Console.Write(same[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 10));
        Console.WriteLine("diff");
        Console.WriteLine(new string('-', 10));

        for (int i = 0; i < diff.GetLength(0); i++)
        {
            if (i == 0)
            {
                Console.WriteLine("  |   " + string.Join(" ", t.Select(c => c)));
                Console.Write("  | ");
            }

            if (i > 0) Console.Write(s[i - 1] + " | ");

            for (int j = 0; j < diff.GetLength(1); j++)
            {
                Console.Write(diff[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine($"ans : {ans}");

        return ans;
    }
}