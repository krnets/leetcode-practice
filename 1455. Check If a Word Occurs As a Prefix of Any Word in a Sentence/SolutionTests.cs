using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var sentence = "i love eating burger";
        var searchWord = "burg";
        var expected = 4;
        Assert.AreEqual(expected, new Solution().IsPrefixOfWord(sentence, searchWord));
    }

    [Test]
    public void ExampleTest2()
    {
        var sentence = "this problem is an easy problem";
        var searchWord = "pro";
        var expected = 2;
        Assert.AreEqual(expected, new Solution().IsPrefixOfWord(sentence, searchWord));
    }

    [Test]
    public void ExampleTest3()
    {
        var sentence = "i am tired";
        var searchWord = "you";
        var expected = -1;
        Assert.AreEqual(expected, new Solution().IsPrefixOfWord(sentence, searchWord));
    }

    [Test]
    public void ExampleTest4()
    {
        var sentence = "i use triple pillow";
        var searchWord = "pill";
        var expected = 4;
        Assert.AreEqual(expected, new Solution().IsPrefixOfWord(sentence, searchWord));
    }

    [Test]
    public void ExampleTest5()
    {
        var sentence = "hello from the other side";
        var searchWord = "they";
        var expected = -1;
        Assert.AreEqual(expected, new Solution().IsPrefixOfWord(sentence, searchWord));
    }
}