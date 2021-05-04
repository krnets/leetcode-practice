public class Solution
{
    public int Reverse(int x)
    {
        long res = 0;

        while (x != 0)
        {
            res = res * 10 + x % 10;
            x /= 10;
        }

        return res < int.MinValue || res > int.MaxValue ? 0 : (int) res;
    }
}
