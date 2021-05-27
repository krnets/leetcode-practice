/*using System;

public class Solution
{
    public int MinCostToMoveChips(int[] position)
    {
        int odd = 0;
        int even = 0;

        foreach (int x in position)
        {
            if (x % 2 == 0) even++;
            else odd++;
        }

        return Math.Min(odd, even);
    }
}*/

/*public class Solution
{
    public int MinCostToMoveChips(int[] position)
    {
        int odd = 0;
        int even = 0;

        foreach (int x in position)
        {
            if (x % 2 == 0) even++;
            else odd++;
        }

        return odd < even ? odd : even;
    }
}*/

public class Solution
{
    public int MinCostToMoveChips(int[] position)
    {
        int oddCount = 0;
        int evenCount = 0;

        for (int i = 0; i < position.Length; i++)
        {
            if ((position[i] & 1) == 0)
                evenCount++;
            else oddCount++;
        }

        return oddCount < evenCount ? oddCount : evenCount;
    }
}