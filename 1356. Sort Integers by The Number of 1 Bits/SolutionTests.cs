using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8};
        int[] expected = {0, 1, 2, 4, 8, 3, 5, 6, 7};
        Assert.AreEqual(expected, new Solution().SortByBits(arr));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1};
        int[] expected = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024};
        Assert.AreEqual(expected, new Solution().SortByBits(arr));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] arr = {10000, 10000};
        int[] expected = {10000, 10000};
        Assert.AreEqual(expected, new Solution().SortByBits(arr));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] arr = {2, 3, 5, 7, 11, 13, 17, 19};
        int[] expected = {2, 3, 5, 17, 7, 11, 13, 19};
        Assert.AreEqual(expected, new Solution().SortByBits(arr));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] arr = {10, 100, 1000, 10000};
        int[] expected = {10, 100, 10000, 1000};
        Assert.AreEqual(expected, new Solution().SortByBits(arr));
    }
}