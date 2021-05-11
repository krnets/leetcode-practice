using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "(()())(())";
        var expected = "()()()";
        Assert.AreEqual(expected, s.RemoveOuterParentheses(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "(()())(())(()(()))";
        var expected = "()()()()(())";
        Assert.AreEqual(expected, s.RemoveOuterParentheses(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "()()";
        var expected = "";
        Assert.AreEqual(expected, s.RemoveOuterParentheses(input));
    }
}