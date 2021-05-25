/*
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        for (int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];
            int warmer = 0;

            for (int j = i + 1; j < temperatures.Length; j++)
            {
                int u = temperatures[j];

                if (u > t)
                {
                    warmer = j - i;
                    break;
                }
            }

            temperatures[i] = warmer;
        }

        return temperatures;
    }
}
*/

// int[] temperatures = {73, 74, 75, 71, 69, 72, 76, 73};
// int[] expected =     {1,  1,  4,  2,  1,  1,  0,  0};
//                        |   |   |   |
//                     73 < 74|   |   |
//                            |   |   |   |
//                         74 < 75|   |   |
//                                |   |   |
//                             75 < 76|   |
//                                    |   |
//                                 71 < 72|
//                                        |
//                                    69 < 72 
//                                              

/*using System.Collections.Generic;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        var stack = new Stack<(int, int)>();
        var ans = new int[n];

        for (int i = 0; i < n; i++)
        {
            int t = temperatures[i];

            while (stack.Count > 0 && t > stack.Peek().Item1)
            {
                var p = stack.Pop();

                ans[p.Item2] = i - p.Item2;
            }

            stack.Push((t, i));
        }

        return ans;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var stack = new Stack<(int, int)>();
        stack.Push((temperatures[^1], temperatures.Length - 1));
        temperatures[^1] = 0;

        for (int dayIndex = temperatures.Length - 2; dayIndex >= 0; dayIndex--)
        {
            var todaysT = temperatures[dayIndex];

            while (stack.Count > 0 && stack.Peek().Item1 <= todaysT)
                stack.Pop();

            if (stack.Count == 0)
                temperatures[dayIndex] = 0;
            else if (stack.Peek().Item1 > todaysT)
                temperatures[dayIndex] = stack.Peek().Item2 - dayIndex;

            stack.Push((todaysT, dayIndex));
        }

        return temperatures;
    }
}