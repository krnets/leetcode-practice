using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = 121;
        Assert.IsTrue(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = -121;
        Assert.IsFalse(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 10;
        Assert.IsFalse(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = -101;
        Assert.IsFalse(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = 0;
        Assert.IsTrue(new Solution().IsPalindrome(input));
    }
}
