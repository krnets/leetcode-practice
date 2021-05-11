using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] points = {new[] {1, 1}, new[] {3, 4}, new[] {-1, 0}};
        var expected = 7;
        Assert.AreEqual(expected, s.MinTimeToVisitAllPoints(points));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] points = {new[] {3, 2}, new[] {-2, -2}};
        var expected = 5;
        Assert.AreEqual(expected, s.MinTimeToVisitAllPoints(points));
    }
}