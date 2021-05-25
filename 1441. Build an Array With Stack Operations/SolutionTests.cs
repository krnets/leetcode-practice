using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] target = {1, 3};
        int n = 3;
        string[] expected = {"Push", "Push", "Pop", "Push"};
        Assert.AreEqual(expected, new Solution().BuildArray(target, n));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] target = {1, 2, 3};
        int n = 3;
        string[] expected = {"Push", "Push", "Push"};
        Assert.AreEqual(expected, new Solution().BuildArray(target, n));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] target = {1, 2};
        int n = 4;
        string[] expected = {"Push", "Push"};
        Assert.AreEqual(expected, new Solution().BuildArray(target, n));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] target = {2, 3, 4};
        int n = 4;
        string[] expected = {"Push", "Pop", "Push", "Push", "Push"};
        Assert.AreEqual(expected, new Solution().BuildArray(target, n));
    }
}