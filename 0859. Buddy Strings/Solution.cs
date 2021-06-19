using System.Linq;

public class Solution
{
    public bool BuddyStrings(string s, string goal)
    {
        if (s.Length != goal.Length) 
            return false;

        if (s.SequenceEqual(goal))
            return s.Distinct().Count() < s.Length;

        var indices = new int[2];
        int countDiff = 0;
        int pos = 0;

        for (int i = 0; i < s.Length; i++)
            if (s[i] != goal[i])
            {
                countDiff++;

                if (countDiff > 2)
                    return false;

                indices[pos] = i;
                pos++;
            }

        return s[indices[0]] == goal[indices[1]] &&
               s[indices[1]] == goal[indices[0]];
    }
}