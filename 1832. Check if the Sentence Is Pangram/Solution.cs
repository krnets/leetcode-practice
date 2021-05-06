/*using System.Linq;

public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var set = sentence.ToHashSet();

        return Enumerable.Range('a', 26).All(c => set.Contains((char) c));
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var set = new HashSet<char>(sentence);

        for (char c = 'a'; c <= 'z'; c++)
            if (!set.Contains(c))
                return false;

        return true;
    }
}