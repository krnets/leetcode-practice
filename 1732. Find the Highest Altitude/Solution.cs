/*using System;

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int curAltitude = 0;
        int maxAltitude = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            curAltitude += gain[i];
            maxAltitude = Math.Max(maxAltitude, curAltitude);
        }

        return maxAltitude;
    }
}*/

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int curAltitude = 0;
        int maxAltitude = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            curAltitude += gain[i];
            maxAltitude = curAltitude > maxAltitude ? curAltitude : maxAltitude;
        }

        return maxAltitude;
    }
}