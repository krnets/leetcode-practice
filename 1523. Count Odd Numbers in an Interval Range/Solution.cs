public class Solution
{
    public int CountOdds(int low, int high)
    {
        return (high + 1) / 2 - low / 2;
    }
}

/*public class Solution
{
    public int CountOdds(int low, int high)
    {
        return (high - low) / 2 + ((high | low) & 1);
    }
}*/