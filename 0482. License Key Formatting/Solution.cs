using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        var chars = Regex.Replace(s.ToUpper(), "-", "").ToCharArray();
        var parts = new List<string>();
        var sb = new StringBuilder();

        for (int i = chars.Length - 1, counter = 0; i >= 0; i--)
        {
            sb.Insert(0, chars[i]);
            counter++;

            if (counter == k)
            {
                counter = 0;
                parts.Insert(0, sb.ToString());
                sb.Clear();
            }
        }

        if (sb.Length > 0)
            parts.Insert(0, sb.ToString());

        return string.Join("-", parts);
    }
}