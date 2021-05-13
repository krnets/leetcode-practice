using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] rectangles = {new[] {5, 8}, new[] {3, 9}, new[] {5, 12}, new[] {16, 5}};
        int expected = 3;
        Assert.AreEqual(expected, s.CountGoodRectangles(rectangles));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] rectangles = {new[] {2, 3}, new[] {3, 7}, new[] {4, 3}, new[] {3, 7}};
        int expected = 3;
        Assert.AreEqual(expected, s.CountGoodRectangles(rectangles));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] rectangles = {new[] {5, 8}, new[] {3, 9}, new[] {3, 12}};
        int expected = 1;
        Assert.AreEqual(expected, s.CountGoodRectangles(rectangles));
    }
}