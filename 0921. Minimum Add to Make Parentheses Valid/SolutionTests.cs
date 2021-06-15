using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "())";
        var expected = 1;
        Assert.Equal(expected, new Solution().MinAddToMakeValid(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "(((";
        var expected = 3;
        Assert.Equal(expected, new Solution().MinAddToMakeValid(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "()";
        var expected = 0;
        Assert.Equal(expected, new Solution().MinAddToMakeValid(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "()))((";
        var expected = 4;
        Assert.Equal(expected, new Solution().MinAddToMakeValid(input));
    }
}