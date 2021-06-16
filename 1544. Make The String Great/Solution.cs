using System;
using System.Text;

/*public class Solution
{
    public string MakeGood(string s)
    {
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (sb.Length > 0)
            {
                int last = sb.Length - 1;

                if (char.ToUpper(c) == char.ToUpper(sb[last]))
                {
                    if (char.IsLower(c) && char.IsUpper(sb[last]) ||
                        char.IsUpper(c) && char.IsLower(sb[last]))
                    {
                        sb.Remove(last, 1);
                    }
                    else sb.Append(c);
                }
                else sb.Append(c);
            }
            else sb.Append(c);
        }

        return sb.ToString();
    }
}*/

public class Solution
{
    public string MakeGood(string s)
    {
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (sb.Length > 0)
            {
                int last = sb.Length - 1;

                if (char.ToUpper(c) == char.ToUpper(sb[last]))
                {
                    if (Math.Abs(sb[last] - c) == 32)
                    {
                        sb.Remove(last, 1);
                    }
                    else sb.Append(c);
                }
                else sb.Append(c);
            }
            else sb.Append(c);
        }

        return sb.ToString();
    }
}