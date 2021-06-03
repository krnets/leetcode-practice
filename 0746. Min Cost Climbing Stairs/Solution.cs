/*using System;
using System.Linq;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] arr = new int[cost.Length];
        arr[0] = cost[0];
        arr[1] = cost[1];

        for (int i = 2; i < cost.Length; i++)
        {
            int choiceA = cost[i] + arr[i - 1];
            int choiceB = cost[i] + arr[i - 2];

            arr[i] = Math.Min(choiceA, choiceB);
        }

        return arr.TakeLast(2).Min();
    }
}*/

using System;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] minCosts = new int[cost.Length + 1];

        for (int i = 2; i < minCosts.Length; i++)
        {
            int choiceA = cost[i - 1] + minCosts[i - 1];
            int choiceB = cost[i - 2] + minCosts[i - 2];

            minCosts[i] = Math.Min(choiceA, choiceB);
        }

        return minCosts[^1];
    }
}