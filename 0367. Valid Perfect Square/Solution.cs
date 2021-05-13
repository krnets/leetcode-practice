/*public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        int lo = 1;
        int hi = num;

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;

            if (num / mid == mid && num % mid == 0)
                return true;

            if (num / mid > mid)
                lo = mid + 1;
            else
                hi = mid - 1;
        }

        return false;
    }
}*/

public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        int hi = num;
        int lo = 1;

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            int x = num / mid;

            if (x == mid && num % mid == 0)
                return true;

            if (x < mid)
                hi = mid - 1;
            else
                lo = mid + 1;
        }

        return false;
    }
}


/*public class Solution  // TC: O(sqrt(num)) too slow for large int
{
    public bool IsPerfectSquare(int num)
    {
        for (int i = 1; i * i <= num; i++)
        {
            if (num == (i * i))
            {
                return true;
            }
        }

        return false;
    }
}*/
