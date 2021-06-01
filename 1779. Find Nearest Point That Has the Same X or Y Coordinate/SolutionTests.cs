using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int x = 3;
        int y = 4;
        int[][] points =
        {
            new[] {1, 2}, new[] {3, 1}, new[] {2, 4}, new[] {2, 3}, new[] {4, 4}
        };
        int expected = 2;
        Assert.AreEqual(expected, new Solution().NearestValidPoint(x, y, points));
    }

    [Test]
    public void ExampleTest2()
    {
        int x = 3;
        int y = 4;
        int[][] points = {new[] {3, 4}};
        int expected = 0;
        Assert.AreEqual(expected, new Solution().NearestValidPoint(x, y, points));
    }

    [Test]
    public void ExampleTest3()
    {
        int x = 3;
        int y = 4;
        int[][] points = {new[] {2, 3}};
        int expected = -1;
        Assert.AreEqual(expected, new Solution().NearestValidPoint(x, y, points));
    }
}