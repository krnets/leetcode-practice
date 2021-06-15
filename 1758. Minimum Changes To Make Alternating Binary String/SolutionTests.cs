using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "0100";
        var expected = 1;
        Assert.Equal(expected, new Solution().MinOperations(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "10";
        var expected = 0;
        Assert.Equal(expected, new Solution().MinOperations(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "1111";
        var expected = 2;
        Assert.Equal(expected, new Solution().MinOperations(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "110010";
        var expected = 2;
        Assert.Equal(expected, new Solution().MinOperations(input));
    }
}