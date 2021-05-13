using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 1};
        int k = 3;
        int t = 0;
        var expected = true;
        Assert.AreEqual(expected, s.ContainsNearbyAlmostDuplicate(nums, k, t));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 0, 1, 1};
        int k = 1;
        int t = 2;
        var expected = true;

        Assert.AreEqual(expected, s.ContainsNearbyAlmostDuplicate(nums, k, t));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 5, 9, 1, 5, 9};
        int k = 2;
        int t = 3;
        var expected = false;

        Assert.AreEqual(expected, s.ContainsNearbyAlmostDuplicate(nums, k, t));
    }
}