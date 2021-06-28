using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums1 = {1, 3};
        int[] nums2 = {2};
        double expected = 2.00000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums1 = {1, 2};
        int[] nums2 = {3, 4};
        double expected = 2.50000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums1 = {0, 0};
        int[] nums2 = {0, 0};
        double expected = 0.00000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums1 = { };
        int[] nums2 = {1};
        double expected = 1.00000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums1 = {2};
        int[] nums2 = { };
        double expected = 2.00000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] nums1 = {1, 1};
        int[] nums2 = {1, 2};
        double expected = 1.00000;
        Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }
}