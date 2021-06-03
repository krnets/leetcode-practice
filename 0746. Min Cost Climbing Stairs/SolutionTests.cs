using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] cost = {10, 15, 20};
        int expected = 15;
        Assert.AreEqual(expected, new Solution().MinCostClimbingStairs(cost));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] cost = {1, 100, 1, 1, 1, 100, 1, 1, 100, 1};
        int expected = 6;
        Assert.AreEqual(expected, new Solution().MinCostClimbingStairs(cost));
    }
}