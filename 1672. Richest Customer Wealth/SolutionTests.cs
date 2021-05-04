using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] input = {new[] {1, 2, 3}, new[] {3, 2, 1}};

        var expected = 6;
        Assert.AreEqual(expected, s.MaximumWealth(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] input = {new[] {1, 5}, new[] {7, 3}, new[] {3, 5}};
        var expected = 10;
        Assert.AreEqual(expected, s.MaximumWealth(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] input = {new[] {2, 8, 7}, new[] {7, 1, 3}, new[] {1, 9, 5}};
        var expected = 17;
        Assert.AreEqual(expected, s.MaximumWealth(input));
    }
}