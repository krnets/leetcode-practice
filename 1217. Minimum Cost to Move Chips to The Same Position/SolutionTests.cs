using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] position = {1, 2, 3};
        int expected = 1;
        Assert.AreEqual(expected, new Solution().MinCostToMoveChips(position));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] position = {2, 2, 2, 3, 3};
        int expected = 2;
        Assert.AreEqual(expected, new Solution().MinCostToMoveChips(position));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] position = {1, 1000000000};
        int expected = 1;
        Assert.AreEqual(expected, new Solution().MinCostToMoveChips(position));
    }
}