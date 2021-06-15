using System.Text;

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        var sbS = new StringBuilder();
        var sbT = new StringBuilder();

        foreach (char c in s)
        {
            if (c == '#')
            {
                if (sbS.Length > 0)
                    sbS.Remove(sbS.Length - 1, 1);
            }
            else sbS.Append(c);
        }

        foreach (char c in t)
        {
            if (c == '#')
            {
                if (sbT.Length > 0)
                    sbT.Remove(sbT.Length - 1, 1);
            }
            else sbT.Append(c);
        }

        return sbS.Equals(sbT);
    }
}