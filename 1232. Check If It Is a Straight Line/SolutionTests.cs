using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] coordinates = {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}, new[] {6, 7}};
        var expected = true;
        Assert.AreEqual(expected, s.CheckStraightLine(coordinates));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] coordinates = {new[] {1, 1}, new[] {2, 2}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}, new[] {7, 7}};
        var expected = false;
        Assert.AreEqual(expected, s.CheckStraightLine(coordinates));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] coordinates = {new[] {0, 0}, new[] {0, 1}, new[] {0, -1}};
        var expected = true;
        Assert.AreEqual(expected, s.CheckStraightLine(coordinates));
    }

    [Test]
    public void ExampleTest4()
    {
        int[][] coordinates = {new[] {2, 4}, new[] {2, 5}, new[] {2, 8}};
        var expected = true;
        Assert.AreEqual(expected, s.CheckStraightLine(coordinates));
    }

    [Test]
    public void ExampleTest5()
    {
        int[][] coordinates = {new[] {1, 2}, new[] {2, 3}, new[] {3, 5}};
        var expected = false;
        Assert.AreEqual(expected, s.CheckStraightLine(coordinates));
    }
}