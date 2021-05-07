using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] grid = {new[] {4, 3, 2, -1}, new[] {3, 2, 1, -1}, new[] {1, 1, -1, -2}, new[] {-1, -1, -2, -3}};
        var expected = 8;
        Assert.AreEqual(expected, s.CountNegatives(grid));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] grid = {new[] {3, 2}, new[] {1, 0}};
        var expected = 0;
        Assert.AreEqual(expected, s.CountNegatives(grid));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] grid = {new[] {1, -1}, new[] {-1, -1}};
        var expected = 3;
        Assert.AreEqual(expected, s.CountNegatives(grid));
    }

    [Test]
    public void ExampleTest4()
    {
        int[][] grid = {new[] {-1}};
        var expected = 1;
        Assert.AreEqual(expected, s.CountNegatives(grid));
    }
}