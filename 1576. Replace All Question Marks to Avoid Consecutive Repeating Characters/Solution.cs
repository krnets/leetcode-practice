using System.Linq;

public class Solution
{
    public string ModifyString(string s)
    {
        var charArray = s.ToCharArray();
        var charsNotInS = Enumerable.Range('a', 26).Select(i => (char) i).Except(s).ToArray();
        int charIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (charArray[i] == '?')
            {
                charArray[i] = charsNotInS[charIndex % charsNotInS.Length];
                charIndex++;
            }
        }

        return new string(charArray);
    }
}