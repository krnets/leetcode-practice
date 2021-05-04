using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        var romanNums = new Dictionary<string, int>
        {
            ["I"] = 1, ["IV"] = 4, ["V"] = 5, ["IX"] = 9, ["X"] = 10,
            ["XL"] = 40, ["L"] = 50, ["XC"] = 90, ["C"] = 100,
            ["CD"] = 400, ["D"] = 500, ["CM"] = 900, ["M"] = 1000
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if ((i + 1) < s.Length && romanNums.ContainsKey(s.Substring(i, 2)))
            {
                result += romanNums[s.Substring(i, 2)];
                i++;
            }
            else result += romanNums[s.Substring(i, 1)];
        }

        return result;
    }
}