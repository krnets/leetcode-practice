using System;

/*public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);

        return nums[^k];
    }
}*/


public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        if (nums.Length == 1)
            return nums[0];

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int pivot = Partition(nums, left, right);

            if (pivot - left + 1 < k)
            {
                k = k - (pivot - left + 1);
                left = pivot + 1;
            }
            else if (pivot - left + 1 > k)
            {
                right = pivot - 1;
            }
            else return nums[pivot];
        }

        return 0;
    }

    private static int Partition(int[] array, int left, int right)
    {
        int mid = (left + right) / 2;
        int pivot = array[mid];

        Swap(array, mid, right);

        int l = left;
        int r = right - 1;

        while (l <= r)
        {
            if (array[l] >= pivot)
                l++;
            else if (array[r] < pivot)
                r--;
            else Swap(array, l++, r--);
        }

        Swap(array, l, right);

        return l;
    }

    private static void Swap(int[] array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }
}