/*using System.Linq;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(x => $"{x}".Length % 2 == 0);
    }
}*/

using System.Linq;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(x => CountDigits(x) % 2 == 0);
    }

    private int CountDigits(int n)
    {
        int count = 0;

        while (n != 0)
        {
            n /= 10;
            count++;
        }

        return count;
    }
}

/*public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
            if (CountDigits(nums[i]) % 2 == 0)
                count++;

        return count;
    }

    private int CountDigits(int n)
    {
        int count = 0;

        while (n != 0)
        {
            n /= 10;
            count++;
        }

        return count;
    }
}*/