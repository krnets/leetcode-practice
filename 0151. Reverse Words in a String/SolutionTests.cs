using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "the sky is blue";
        var expected = "blue is sky the";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "  hello world  ";
        var expected = "world hello";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "a good   example";
        var expected = "example good a";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "  Bob    Loves  Alice   ";
        var expected = "Alice Loves Bob";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "Alice does not even like bob";
        var expected = "bob like even not does Alice";
        Assert.AreEqual(expected, new Solution().ReverseWords(input));
    }
}