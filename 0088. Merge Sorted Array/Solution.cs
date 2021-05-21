/*public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1.Length == m)
            return;

        m--;
        n--;

        for (int i = nums1.Length - 1; i >= 0; i--)
        {
            if (m < 0 && n >= 0)
            {
                nums1[i] = nums2[n];
                n--;
                continue;
            }

            if (m >= 0 && n < 0)
            {
                nums1[i] = nums1[m];
                m--;
                continue;
            }

            if (nums1[m] >= nums2[n])
            {
                nums1[i] = nums1[m];
                nums1[m] = 0;
                m--;
            }
            else if (nums1[m] < nums2[n])
            {
                nums1[i] = nums2[n];
                n--;
            }
        }
    }
}*/

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int end = m + n - 1;
        m--;
        n--;

        while (m >= 0 && n >= 0)
        {
            if (nums1[m] > nums2[n])
                nums1[end--] = nums1[m--];
            else nums1[end--] = nums2[n--];
        }

        while (n >= 0)
        {
            nums1[end--] = nums2[n--];
        }
    }
}