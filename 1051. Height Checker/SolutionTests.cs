using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] heights = {1, 1, 4, 2, 1, 3};
        int expected = 3;
        Assert.AreEqual(expected, new Solution().HeightChecker(heights));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] heights = {5, 1, 2, 3, 4};
        int expected = 5;
        Assert.AreEqual(expected, new Solution().HeightChecker(heights));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] heights = {1, 2, 3, 4, 5};
        int expected = 0;
        Assert.AreEqual(expected, new Solution().HeightChecker(heights));
    }
}