using System;

/*public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int l = (m + n + 1) / 2;
        int r = (m + n + 2) / 2;

        return (GetKth(nums1, 0, nums2, 0, l) + GetKth(nums1, 0, nums2, 0, r)) / 2;
    }

    private double GetKth(int[] nums1, int mStart, int[] nums2, int nStart, int k)
    {
        if (mStart > nums1.Length - 1)
            return nums2[nStart + k - 1];

        if (nStart > nums2.Length - 1)
            return nums1[mStart + k - 1];

        if (k == 1)
            return Math.Min(nums1[mStart], nums2[nStart]);

        int mMid = int.MaxValue;
        int nMid = int.MaxValue;

        if (mStart + k / 2 - 1 < nums1.Length) mMid = nums1[mStart + k / 2 - 1];
        if (nStart + k / 2 - 1 < nums2.Length) nMid = nums2[nStart + k / 2 - 1];

        return mMid < nMid
            ? GetKth(nums1, mStart + k / 2, nums2, nStart, k - k / 2)
            : GetKth(nums1, mStart, nums2, nStart + k / 2, k - k / 2);
    }
}*/

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int x = nums1.Length;
        int y = nums2.Length;

        int low = 0;
        int high = x;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (x + y + 1) / 2 - partitionX;

            int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

            int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                int leftMax = Math.Max(maxLeftX, maxLeftY);

                if ((x + y) % 2 == 0)
                {
                    int rightMin = Math.Min(minRightX, minRightY);

                    return (leftMax + rightMin) / 2.0;
                }

                return leftMax;
            }

            if (maxLeftX > minRightY)
                high = partitionX - 1;

            else low = partitionX + 1;
        }

        return 0.0;
    }
}