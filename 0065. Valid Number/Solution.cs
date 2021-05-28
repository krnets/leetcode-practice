/*using System.Text.RegularExpressions;

public class Solution
{
    public bool IsNumber(string s)
    {
        var start = "^";
        var end = "$";
        var spaces = "\\s*";
        var sign = "[-+]?";
        var or = "|";
        var exponent = "[eE]";
        var digitZeroMore = "\\d*";
        var digitPlus = "\\d+";
        var optional = "?";
        var dot = "\\.";

        var pattern = start + sign +
                      "(" + "(" + digitPlus + "(" + dot + digitZeroMore + ")" + optional + ")" +
                      or +
                      "(" + dot + digitPlus + ")" + ")" +
                      "(" + exponent + sign + digitPlus + ")" +
                      optional + spaces + end;

        return Regex.IsMatch(s, pattern);
    }
}*/

/*
public class Solution
{
    public bool IsNumber(string s)
    {
        var sNorm = s.ToLower();

        if (sNorm[1..].Contains('+') && !sNorm.StartsWith('+') && !sNorm[1..].Contains("e+")) return false;
        if (sNorm[1..].Contains('-') && !sNorm.StartsWith('-') && !sNorm[1..].Contains("e-")) return false;

        var eSplit = sNorm.Split("e");

        if (eSplit.Length > 2) return false;

        if (eSplit.Length == 2)
        {
            if (!long.TryParse(eSplit[1], out _)) return false;

            sNorm = eSplit[0];
        }

        return decimal.TryParse(sNorm, out _);
    }
}
*/


/*public class Solution
{
    public bool IsNumber(string s)
    {
        bool seenExp = false;
        bool seenDot = false;
        bool seenNum = false;

        s = s.ToLower().Trim();

        for (int i = 0; i < s.Length; ++i)
            switch (s[i])
            {
                case '.':
                    if (seenDot || seenExp) return false;
                    seenDot = true;
                    break;
                case 'e':
                    if (seenExp || !seenNum) return false;
                    seenExp = true;
                    seenNum = false;
                    break;
                case '+':
                case '-':
                    if (i > 0 && s[i - 1] != 'e') return false;
                    seenNum = false;
                    break;
                default:
                    if (s[i] - '0' < 0 || s[i] - '0' > 9) return false;
                    seenNum = true;
                    break;
            }

        return seenNum;
    }
}*/

public class Solution
{
    public bool IsNumber(string s)
    {
        bool seenDot = false;
        bool seenExp = false;
        bool seenNum = false;

        s = s.ToLower().Trim();

        for (int i = 0; i < s.Length; ++i)
            switch (s[i])
            {
                case '.':
                    if (seenDot || seenExp) return false;
                    seenDot = true;
                    break;
                case 'e':
                    if (seenExp || !seenNum) return false;
                    seenExp = true;
                    seenNum = false;
                    break;
                case '+':
                case '-':
                    if (i > 0 && s[i - 1] != 'e') return false;
                    seenNum = false;
                    break;
                default:
                    if (!char.IsDigit(s[i])) return false;
                    seenNum = true;
                    break;
            }

        return seenNum;
    }
}