using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string[] dictionary = {"cat", "bat", "rat"};
        var sentence = "the cattle was rattled by the battery";
        var expected = "the cat was rat by the bat";
        Assert.Equal(expected, new Solution().ReplaceWords(dictionary, sentence));
    }

    [Fact]
    public void ExampleTest2()
    {
        string[] dictionary = {"a", "b", "c"};
        var sentence = "aadsfasf absbs bbab cadsfafs";
        var expected = "a a b c";
        Assert.Equal(expected, new Solution().ReplaceWords(dictionary, sentence));
    }

    [Fact]
    public void ExampleTest3()
    {
        string[] dictionary = {"a", "aa", "aaa", "aaaa"};
        var sentence = "a aa a aaaa aaa aaa aaa aaaaaa bbb baba ababa";
        var expected = "a a a a a a a a bbb baba a";
        Assert.Equal(expected, new Solution().ReplaceWords(dictionary, sentence));
    }

    [Fact]
    public void ExampleTest4()
    {
        string[] dictionary = {"catt", "cat", "bat", "rat"};
        var sentence = "the cattle was rattled by the battery";
        var expected = "the cat was rat by the bat";
        Assert.Equal(expected, new Solution().ReplaceWords(dictionary, sentence));
    }

    [Fact]
    public void ExampleTest5()
    {
        string[] dictionary = {"ac", "ab"};
        var sentence = "it is abnormal that this solution is accepted";
        var expected = "it is ab that this solution is ac";
        Assert.Equal(expected, new Solution().ReplaceWords(dictionary, sentence));
    }
}