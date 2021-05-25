using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] prices = {8, 4, 6, 2, 3};
        int[] expected = {4, 2, 4, 2, 3};
        Assert.AreEqual(expected, new Solution().FinalPrices(prices));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] prices = {1, 2, 3, 4, 5};
        int[] expected = {1, 2, 3, 4, 5};
        Assert.AreEqual(expected, new Solution().FinalPrices(prices));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] prices = {10, 1, 1, 6};
        int[] expected = {9, 0, 1, 6};
        Assert.AreEqual(expected, new Solution().FinalPrices(prices));
    }
}