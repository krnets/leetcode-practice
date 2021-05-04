using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3, 4};
        int[] expected = {1, 3, 6, 10};
        Assert.AreEqual(expected, s.RunningSum(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 1, 1, 1, 1};
        int[] expected = {1, 2, 3, 4, 5};
        Assert.AreEqual(expected, s.RunningSum(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {3, 1, 2, 10, 1};
        int[] expected = {3, 4, 6, 16, 17};
        Assert.AreEqual(expected, s.RunningSum(input));
    }
}