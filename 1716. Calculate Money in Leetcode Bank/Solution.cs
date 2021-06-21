public class Solution
{
    public int TotalMoney(int n)
    {
        int week = 1;
        int total = 0;
        int amount = 0;

        for (int i = 1; i <= n; i++)
        {
            total += (amount + week);
            amount++;

            if (i % 7 == 0)
            {
                week++;
                amount = 0;
            }
        }

        return total;
    }
}