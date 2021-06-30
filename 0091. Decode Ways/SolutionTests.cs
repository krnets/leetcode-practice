using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "12";
        var expected = 2;
        Assert.Equal(expected, new Solution().NumDecodings(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "226";
        var expected = 3;
        Assert.Equal(expected, new Solution().NumDecodings(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "0";
        var expected = 0;
        Assert.Equal(expected, new Solution().NumDecodings(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "06";
        var expected = 0;
        Assert.Equal(expected, new Solution().NumDecodings(input));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = "11106";
        var expected = 2;
        Assert.Equal(expected, new Solution().NumDecodings(input));
    }
}