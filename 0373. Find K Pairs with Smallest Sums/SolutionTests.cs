using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums1 = {1, 7, 11};
        int[] nums2 = {2, 4, 6};
        int k = 3;
        int[][] expected = {new[] {1, 2}, new[] {1, 4}, new[] {1, 6}};
        Assert.Equal(expected, new Solution().KSmallestPairs(nums1, nums2, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums1 = {1, 7, 11};
        int[] nums2 = {2, 4, 6};
        int k = 3;
        int[][] expected = {new[] {1, 2}, new[] {1, 4}, new[] {1, 6}};
        Assert.Equal(expected, new Solution().KSmallestPairs(nums1, nums2, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums1 = {1, 2};
        int[] nums2 = {3};
        int k = 3;
        int[][] expected = {new[] {1, 3}, new[] {2, 3}};
        Assert.Equal(expected, new Solution().KSmallestPairs(nums1, nums2, k));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums1 = {1, 1, 2};
        int[] nums2 = {1, 2, 3};
        int k = 2;
        int[][] expected = {new[] {1, 1}, new[] {1, 1}};
        Assert.Equal(expected, new Solution().KSmallestPairs(nums1, nums2, k));
    }
}