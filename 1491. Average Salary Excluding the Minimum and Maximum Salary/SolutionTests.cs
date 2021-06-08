using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] salary = {4000, 3000, 1000, 2000};
        var expected = 2500.00000;
        Assert.AreEqual(expected, new Solution().Average(salary));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] salary = {1000, 2000, 3000};
        var expected = 2000.00000;
        Assert.AreEqual(expected, new Solution().Average(salary));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] salary = {6000, 5000, 4000, 3000, 2000, 1000};
        var expected = 3500.00000;
        Assert.AreEqual(expected, new Solution().Average(salary));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] salary = {8000, 9000, 2000, 3000, 6000, 1000};
        var expected = 4750.00000;
        Assert.AreEqual(expected, new Solution().Average(salary));
    }
}