/*using System.Collections.Generic;

public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        int n = prices.Length;
        var ans = new int[n];
        var stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int price = prices[i];
            ans[i] = price;

            while (stack.TryPeek(out int j) && prices[j] >= price)
            {
                ans[j] = prices[j] - price;
                stack.Pop();
            }

            stack.Push(i);
        }

        return ans;
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count != 0 && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }

            stack.Push(i);
        }

        return prices;
    }
}*/

/*public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        var ans = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
            ans[i] = prices[i] - GetDiscount(i, prices, prices[i]);

        return ans;
    }

    private int GetDiscount(int i, int[] prices, int item)
    {
        while (++i < prices.Length)
            if (item >= prices[i])
                return prices[i];

        return 0;
    }
}*/

public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[i] >= prices[j])
                {
                    prices[i] -= prices[j];
                    break;
                }
            }
        }

        return prices;
    }
}