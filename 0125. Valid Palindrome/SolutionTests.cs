using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "A man, a plan, a canal: Panama";
        Assert.IsTrue(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "race a car";
        Assert.IsFalse(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "racecar";
        Assert.IsTrue(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = " ";
        Assert.IsTrue(new Solution().IsPalindrome(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "0P";
        Assert.IsFalse(new Solution().IsPalindrome(input));
    }
}