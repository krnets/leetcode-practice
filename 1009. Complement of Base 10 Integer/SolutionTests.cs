using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 5;
        var expected = 2;
        Assert.Equal(expected, new Solution().BitwiseComplement(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 7;
        var expected = 0;
        Assert.Equal(expected, new Solution().BitwiseComplement(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = 10;
        var expected = 5;
        Assert.Equal(expected, new Solution().BitwiseComplement(input));
    }
}