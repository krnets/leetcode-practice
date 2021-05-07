using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] mat = {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
        int expected = 25;
        Assert.AreEqual(expected, s.DiagonalSum(mat));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] mat = {new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}};
        int expected = 8;
        Assert.AreEqual(expected, s.DiagonalSum(mat));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] mat = {new[] {5}};
        int expected = 5;
        Assert.AreEqual(expected, s.DiagonalSum(mat));
    }
}