using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var word = "apple";
        Trie obj = new Trie();
        obj.Insert(word);
        bool param_2 = obj.Search(word);
        Assert.True(param_2);
    }

    [Fact]
    public void ExampleTest2()
    {
        var word = "apple";
        var prefix = "app";
        Trie obj = new Trie();
        obj.Insert(word);
        bool param_3 = obj.StartsWith(prefix);
        Assert.True(param_3);
    }
}