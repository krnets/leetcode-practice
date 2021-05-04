/*using System.Text.RegularExpressions;

public class Solution
{
    public string DefangIPaddr(string address)
    {
        return Regex.Replace(address, @"\.", @"[.]");
    }
}*/

/*using System.Linq;

public class Solution
{
    public string DefangIPaddr(string address)
    {
        return string.Concat(address.Select(c => c == '.' ? "[.]" : $"{c}"));
    }
}*/

using System.Text;

public class Solution
{
    public string DefangIPaddr(string address)
    {
        var sb = new StringBuilder();

        foreach (char c in address) 
            sb.Append(c == '.' ? "[.]" : $"{c}");

        return sb.ToString();
    }
}