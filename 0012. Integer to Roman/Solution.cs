/*using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        var romanNums = new SortedDictionary<int, string>
        {
            [1] = "I", [4] = "IV", [5] = "V", [9] = "IX", [10] = "X",
            [40] = "XL", [50] = "L", [90] = "XC", [100] = "C",
            [400] = "CD", [500] = "D", [900] = "CM", [1000] = "M"
        };

        var sb = new StringBuilder();

        foreach (var (i, roman) in romanNums.Reverse())
        {
            while (num / i > 0)
            {
                sb.Append(roman);
                num -= i;
            }
        }

        return sb.ToString();
    }
}*/

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        var romanNums = new Dictionary<int, string>
        {
            [1000] = "M", [900] = "CM", [500] = "D", [400] = "CD",
            [100] = "C", [90] = "XC", [50] = "L", [40] = "XL",
            [10] = "X", [9] = "IX", [5] = "V", [4] = "IV", [1] = "I"
        };

        var sb = new StringBuilder();

        foreach (var (i, roman) in romanNums)
        {
            while (num / i > 0)
            {
                sb.Append(roman);
                num -= i;
            }
        }

        return sb.ToString();
    }
}