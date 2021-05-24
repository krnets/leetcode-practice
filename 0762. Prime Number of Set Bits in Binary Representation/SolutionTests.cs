using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int left = 6;
        int right = 10;
        int expected = 4;
        Assert.AreEqual(expected, new Solution().CountPrimeSetBits(left, right));
    }

    [Test]
    public void ExampleTest2()
    {
        int left = 10;
        int right = 15;
        int expected = 5;
        Assert.AreEqual(expected, new Solution().CountPrimeSetBits(left, right));
    }

    [Test]
    public void ExampleTest3()
    {
        int left = 842;
        int right = 888;
        int expected = 23;
        Assert.AreEqual(expected, new Solution().CountPrimeSetBits(left, right));
    }

    [Test]
    public void ExampleTest4()
    {
        int left = 248657;
        int right = 257888;
        int expected = 3381;
        Assert.AreEqual(expected, new Solution().CountPrimeSetBits(left, right));
    }

    [Test]
    public void ExampleTest5()
    {
        int left = 977581;
        int right = 983119;
        int expected = 2036;
        Assert.AreEqual(expected, new Solution().CountPrimeSetBits(left, right));
    }
}