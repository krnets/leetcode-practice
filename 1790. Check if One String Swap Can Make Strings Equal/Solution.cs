public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        int[] indices = new int[2];
        int countDiff = 0;
        int pos = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                countDiff++;

                if (countDiff > 2)
                    return false;

                indices[pos] = i;
                pos++;
            }
        }

        return countDiff == 0 ||
               s1[indices[0]] == s2[indices[1]] &&
               s1[indices[1]] == s2[indices[0]];
    }
}