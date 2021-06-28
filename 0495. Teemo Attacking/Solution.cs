/*public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int total = 0;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            if (timeSeries[i] - timeSeries[i - 1] < duration)
                total += (timeSeries[i] - timeSeries[i - 1]);
            else total += duration;
        }

        return total + duration;
    }
}*/

public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int total = 0;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            int interval = timeSeries[i] - timeSeries[i - 1];

            if (interval < duration)
                total += interval;
            else total += duration;
        }

        return total + duration;
    }
}