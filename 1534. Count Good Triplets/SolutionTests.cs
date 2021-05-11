using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] arr = {3, 0, 1, 1, 9, 7};
        int a = 7, b = 2, c = 3;
        var expected = 4;
        Assert.AreEqual(expected, s.CountGoodTriplets(arr, a, b, c));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {1, 1, 2, 2, 3};
        int a = 0, b = 0, c = 1;
        var expected = 0;
        Assert.AreEqual(expected, s.CountGoodTriplets(arr, a, b, c));
    }
}