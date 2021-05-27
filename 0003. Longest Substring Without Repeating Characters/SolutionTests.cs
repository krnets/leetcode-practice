using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "abcabcbb";
        var expected = 3;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "bbbb";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "pwwkew";
        var expected = 3;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "toblerone";
        var expected = 6;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }

    [Test]
    public void ExampleTest6()
    {
        var input = " ";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(input));
    }
}