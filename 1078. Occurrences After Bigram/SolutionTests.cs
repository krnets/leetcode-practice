using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var text = "alice is a good girl she is a good student";
        var first = "a";
        var second = "good";
        string[] expected = {"girl", "student"};
        Assert.Equal(expected, new Solution().FindOcurrences(text, first, second));
    }

    [Fact]
    public void ExampleTest2()
    {
        var text = "we will we will rock you";
        var first = "we";
        var second = "will";
        string[] expected = {"we", "rock"};
        Assert.Equal(expected, new Solution().FindOcurrences(text, first, second));
    }

    [Fact]
    public void ExampleTest3()
    {
        var text = "jkypmsxd jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa kcyxdfnoa jkypmsxd kcyxdfnoa";
        var first = "kcyxdfnoa";
        var second = "jkypmsxd";
        string[] expected = {"kcyxdfnoa", "kcyxdfnoa", "kcyxdfnoa"};
        Assert.Equal(expected, new Solution().FindOcurrences(text, first, second));
    }

    [Fact]
    public void ExampleTest4()
    {
        var text = "we we we we will rock you";
        var first = "we";
        var second = "we";
        string[] expected = {"we", "we", "will"};
        Assert.Equal(expected, new Solution().FindOcurrences(text, first, second));
    }
}