using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] target = {1, 2, 3, 4};
        int[] arr = {2, 4, 1, 3};
        var expected = true;
        Assert.AreEqual(expected, new Solution().CanBeEqual(target, arr));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] target = {7};
        int[] arr = {7};
        var expected = true;
        Assert.AreEqual(expected, new Solution().CanBeEqual(target, arr));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] target = {1, 12};
        int[] arr = {12, 1};
        var expected = true;
        Assert.AreEqual(expected, new Solution().CanBeEqual(target, arr));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] target = {3, 7, 9};
        int[] arr = {3, 7, 11};
        var expected = false;
        Assert.AreEqual(expected, new Solution().CanBeEqual(target, arr));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] target = {1, 1, 1, 1, 1};
        int[] arr = {1, 1, 1, 1, 1};
        var expected = true;
        Assert.AreEqual(expected, new Solution().CanBeEqual(target, arr));
    }
}