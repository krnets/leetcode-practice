/*using System.Collections.Generic;

public class Solution
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        int count = 0;
        var queue = new Queue<int>();

        for (int i = 1; i <= queryTime; i++)
        {
            for (int j = 0; j < startTime.Length; j++)
            {
                if (startTime[j] == i)
                {
                    queue.Enqueue(i);
                    count++;
                }
            }

            for (int j = 0; j < endTime.Length; j++)
            {
                if (i < queryTime && endTime[j] == i)
                {
                    queue.Dequeue();
                    count--;
                }
            }
        }

        return count;
    }
}*/

public class Solution
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        int count = 0;

        for (int i = 0; i < startTime.Length; i++)
        {
            if (startTime[i] <= queryTime && queryTime <= endTime[i])
                count++;
        }

        return count;
    }
}