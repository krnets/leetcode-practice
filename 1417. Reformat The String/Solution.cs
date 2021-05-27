/*using System.Linq;
using System.Text;

public class Solution
{
    public string Reformat(string s)
    {
        var letters = s.Where(char.IsLetter).ToArray();
        var digits = s.Where(char.IsDigit).ToArray();
        var sb = new StringBuilder();

        if (letters.Length > digits.Length)
        {
            if (letters.Length - digits.Length > 1)
                return string.Empty;

            for (int i = 0; i < digits.Length; i++)
            {
                sb.Append(letters[i]);
                sb.Append(digits[i]);
            }

            sb.Append(letters[^1]);
        }
        else if (letters.Length < digits.Length)
        {
            if (digits.Length - letters.Length > 1)
                return string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                sb.Append(digits[i]);
                sb.Append(letters[i]);
            }

            sb.Append(digits[^1]);
        }
        else
        {
            for (int i = 0; i < digits.Length; i++)
            {
                sb.Append(digits[i]);
                sb.Append(letters[i]);
            }
        }

        return sb.ToString();
    }
}*/

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string Reformat(string s)
    {
        var letters = new Queue<char>();
        var digits = new Queue<char>();
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsDigit(c))
                digits.Enqueue(c);
            else letters.Enqueue(c);
        }

        int lenDiff = letters.Count - digits.Count;

        if (lenDiff < -1 || lenDiff > 1)
            return string.Empty;

        while (digits.Count > 0 || letters.Count > 0)
        {
            digits.TryDequeue(out char digit);
            letters.TryDequeue(out char letter);

            if (lenDiff < 1)
            {
                sb.Append(digit);
                if (letter != default) sb.Append(letter);
            }
            else
            {
                sb.Append(letter);
                if (digit != default) sb.Append(digit);
            }
        }

        return sb.ToString();
    }
}