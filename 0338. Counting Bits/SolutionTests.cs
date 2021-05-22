using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int num = 2;
        int[] expected = {0, 1, 1};
        Assert.AreEqual(expected, new Solution().CountBits(num));
    }

    [Test]
    public void ExampleTest2()
    {
        int num = 5;
        int[] expected = {0, 1, 1, 2, 1, 2};
        Assert.AreEqual(expected, new Solution().CountBits(num));
    }
}