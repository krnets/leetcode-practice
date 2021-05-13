using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 1};
        var k = 3;
        var expected = true;

        Assert.AreEqual(expected, s.ContainsNearbyDuplicate(nums, k));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 0, 1, 1};
        var k = 1;
        var expected = true;

        Assert.AreEqual(expected, s.ContainsNearbyDuplicate(nums, k));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 2, 3, 1, 2, 3};
        var k = 2;
        var expected = false;

        Assert.AreEqual(expected, s.ContainsNearbyDuplicate(nums, k));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {99, 99};
        var k = 2;
        var expected = true;

        Assert.AreEqual(expected, s.ContainsNearbyDuplicate(nums, k));
    }
}