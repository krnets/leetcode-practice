using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] arr = {2, 1};
        var expected = false;
        Assert.AreEqual(expected, s.ValidMountainArray(arr));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {3, 5, 5};
        var expected = false;
        Assert.AreEqual(expected, s.ValidMountainArray(arr));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] arr = {0, 3, 2, 1};
        var expected = true;
        Assert.AreEqual(expected, s.ValidMountainArray(arr));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] arr = {2, 0, 2};
        var expected = false;
        Assert.AreEqual(expected, s.ValidMountainArray(arr));
    }
}