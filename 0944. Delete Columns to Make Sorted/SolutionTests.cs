using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] input = {"cba", "daf", "ghi"};
        var expected = 1;
        Assert.AreEqual(expected, new Solution().MinDeletionSize(input));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] input = {"a", "b"};
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MinDeletionSize(input));
    }

    [Test]
    public void ExampleTest3()
    {
        string[] input = {"zyx", "wvu", "tsr"};
        var expected = 3;
        Assert.AreEqual(expected, new Solution().MinDeletionSize(input));
    }
}