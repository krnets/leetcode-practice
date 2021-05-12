/*using System.Linq;
using System.Text.RegularExpressions;

public class Solution
{
    public string ReformatNumber(string number)
    {
        string digits = string.Concat(number.Where(char.IsDigit));

        return Regex.Replace(digits, "...?(?=..)", "$0-");
    }
}*/

using System.Linq;
using System.Text;

public class Solution
{
    public string ReformatNumber(string number)
    {
        var digits = string.Concat(number.Where(char.IsDigit));
        var sb = new StringBuilder();

        int i = 0;
        int length = digits.Length;

        while (length > 4)
        {
            sb.Append(digits.Substring(i, 3)).Append("-");
            i += 3;
            length -= 3;
        }

        switch (length)
        {
            case 4:
                sb.Append(digits.Substring(i, 2)).Append("-")
                    .Append(digits.Substring(i + 2, 2));
                break;
            case 3:
                sb.Append(digits.Substring(i, 3));
                break;
            case 2:
                sb.Append(digits.Substring(i, 2));
                break;
            default:
                sb.Append(digits[i..]);
                break;
        }

        return sb.ToString();
    }
}