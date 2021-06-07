using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "ababa";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().RemovePalindromeSub(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "abb";
        var expected = 2;
        Assert.AreEqual(expected, new Solution().RemovePalindromeSub(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "baabb";
        var expected = 2;
        Assert.AreEqual(expected, new Solution().RemovePalindromeSub(input));
    }
}