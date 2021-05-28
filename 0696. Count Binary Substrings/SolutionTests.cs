using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "00110011";
        var expected = 6;
        Assert.AreEqual(expected, new Solution().CountBinarySubstrings(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "10101";
        var expected = 4;
        Assert.AreEqual(expected, new Solution().CountBinarySubstrings(input));
    }
}