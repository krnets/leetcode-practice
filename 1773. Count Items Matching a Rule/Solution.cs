using System.Collections.Generic;

public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;

        foreach (var sub in items)
        {
            switch (ruleKey)
            {
                case "type" when sub[0] == ruleValue:
                case "color" when sub[1] == ruleValue:
                case "name" when sub[2] == ruleValue:
                    count++;
                    break;
            }
        }

        return count;
    }
}