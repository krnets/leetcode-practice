using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

/*public class Solution
{
    public int NumDifferentIntegers(string word)
    {
        return Regex.Matches(word, @"\d+")
            .Select(m => BigInteger.Parse(m.Value))
            .Distinct()
            .Count();
    }
}*/

public class Solution
{
    public int NumDifferentIntegers(string word)
    {
        return Regex.Matches(word, @"\d+")
            .Select(m => m.Value.TrimStart('0'))
            .Distinct()
            .Count();
    }
}