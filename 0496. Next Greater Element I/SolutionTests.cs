using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums1 = {4, 1, 2};
        int[] nums2 = {1, 3, 4, 2};
        int[] expected = {-1, 3, -1};
        Assert.AreEqual(expected, new Solution().NextGreaterElement(nums1, nums2));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums1 = {2, 4};
        int[] nums2 = {1, 2, 3, 4};
        int[] expected = {3, -1};
        Assert.AreEqual(expected, new Solution().NextGreaterElement(nums1, nums2));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums1 = {1, 3, 5, 2, 4};
        int[] nums2 = {6, 5, 4, 3, 2, 1, 7};
        int[] expected = {7, 7, 7, 7, 7};
        Assert.AreEqual(expected, new Solution().NextGreaterElement(nums1, nums2));
    }
}