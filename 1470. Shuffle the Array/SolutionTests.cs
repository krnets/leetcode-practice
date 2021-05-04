using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {2, 5, 1, 3, 4, 7};
        int n = 3;
        int[] expected = {2, 3, 5, 4, 1, 7};
        Assert.AreEqual(expected, s.Shuffle(input, n));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2, 3, 4, 4, 3, 2, 1};
        int n = 4;
        int[] expected = {1, 4, 2, 3, 3, 2, 4, 1};
        Assert.AreEqual(expected, s.Shuffle(input, n));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {1, 1, 2, 2};
        int n = 2;
        int[] expected = {1, 2, 1, 2};
        Assert.AreEqual(expected, s.Shuffle(input, n));
    }
}