using System.Linq;
using System.Text.RegularExpressions;

/*
public class Solution
{
    public bool IsLongPressedName(string name, string typed)
    {
        var pattern = string.Concat(name.Select(c => $"{c}" + "{1,}"));

        return Regex.IsMatch(typed, $"^{pattern}$");
    }
}
*/


public class Solution
{
    public bool IsLongPressedName(string name, string typed)
    {
        int nameLength = name.Length;
        int typedLength = typed.Length;

        if (typedLength < nameLength)
            return false;

        int i = 0;
        int j = 0;

        while (i < nameLength)
        {
            char c = name[i];
            int count = 1;
            i++;

            while (i < nameLength && name[i] == c)
            {
                i++;
                count++;
            }

            while (j < typedLength && typed[j] == c)
            {
                count--;
                j++;
            }

            if (count > 0 || nameLength - i > typedLength - j)
                return false;
        }

        return j == typedLength;
    }
}