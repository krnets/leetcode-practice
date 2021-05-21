using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "Let's take LeetCode contest";
        var expected = "s'teL ekat edoCteeL tsetnoc";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "God Ding";
        var expected = "doG gniD";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }
}