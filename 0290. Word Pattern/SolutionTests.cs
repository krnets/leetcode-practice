using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var pattern = "abba";
        var s = "dog cat cat dog";
        Assert.True(new Solution().WordPattern(pattern, s));
    }

    [Fact]
    public void ExampleTest2()
    {
        var pattern = "abba";
        var s = "dog cat cat fish";
        Assert.False(new Solution().WordPattern(pattern, s));
    }

    [Fact]
    public void ExampleTest3()
    {
        var pattern = "aaaa";
        var s = "dog cat cat dog";
        Assert.False(new Solution().WordPattern(pattern, s));
    }


    [Fact]
    public void ExampleTest4()
    {
        var pattern = "abba";
        var s = "dog dog dog";
        Assert.False(new Solution().WordPattern(pattern, s));
    }

    [Fact]
    public void ExampleTest5()
    {
        var pattern = "abba";
        var s = "dog dog dog dog";
        Assert.False(new Solution().WordPattern(pattern, s));
    }
}