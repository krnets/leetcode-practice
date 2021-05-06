using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {8, 1, 2, 2, 3};
        int[] expected = {4, 0, 1, 1, 3};
        Assert.AreEqual(expected, s.SmallerNumbersThanCurrent(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {6, 5, 4, 8};
        int[] expected = {2, 1, 0, 3};
        Assert.AreEqual(expected, s.SmallerNumbersThanCurrent(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {7, 7, 7, 7};
        int[] expected = {0, 0, 0, 0};
        Assert.AreEqual(expected, s.SmallerNumbersThanCurrent(input));
    }
}