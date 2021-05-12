using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "cbaebabacd";
        var p = "abc";
        int[] expected = {0, 6};
        Assert.AreEqual(expected, s.FindAnagrams(input, p));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "abab";
        var p = "ab";
        int[] expected = {0, 1, 2};
        Assert.AreEqual(expected, s.FindAnagrams(input, p));
    }
}