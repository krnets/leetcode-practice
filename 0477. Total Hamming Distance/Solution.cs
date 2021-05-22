/*public class Solution
{
    public int TotalHammingDistance(int[] nums)
    {
        int count = 0;
        int mask = 1;

        for (int i = 0; i < 32; i++)
        {
            int k = 0;

            foreach (int num in nums)
                if ((num & mask) != 0)
                    k++;

            count += k * (nums.Length - k);
            mask <<= 1;
        }

        return count;
    }
}*/


/*
using System.Linq;
 
public class Solution
{
    public int TotalHammingDistance(int[] nums)
    {
        int count = 0;
        int mask = 1;

        for (int i = 0; i < 32; i++)
        {
            int k = nums.Count(num => (num & mask) != 0);
            count += k * (nums.Length - k);
            mask <<= 1;
        }

        return count;
    }
}*/

/*public class Solution
{
    public int TotalHammingDistance(int[] nums)
    {
        int totalDistance = 0;

        for (int i = 0; i < 32; i++)
        {
            int distance = 0;

            foreach (var x in nums)
            {
                distance += (x >> i) & 1;
            }

            totalDistance += distance * (nums.Length - distance);
        }

        return totalDistance;
    }
}*/

using System.Linq;

public class Solution
{
    public int TotalHammingDistance(int[] nums)
    {
        int[] bitCount = new int[32];

        foreach (var num in nums)
        {
            int i = 0;
            int x = num;

            while (x != 0)
            {
                bitCount[i] += x & 1;
                i++;
                x >>= 1;
            }
        }

        return bitCount.Sum(bit => bit * (nums.Length - bit));
    }
}