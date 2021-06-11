/*public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] < arr[mid + 1])
                left = mid + 1;

            else right = mid;
        }

        return right;
    }
}*/

public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        var (lo, hi) = (0, arr.Length - 1);

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;

            if (arr[mid] < arr[mid + 1])
                lo = mid + 1;

            else hi = mid;
        }

        return lo;
    }
}