using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var num = 100;
        var expected = "202";
        Assert.Equal(expected, new Solution().ConvertToBase7(num));
    }

    [Fact]
    public void ExampleTest2()
    {
        var num = -7;
        var expected = "-10";
        Assert.Equal(expected, new Solution().ConvertToBase7(num));
    }
    [Fact]
    public void ExampleTest3()
    {
        var num = 0;
        var expected = "0";
        Assert.Equal(expected, new Solution().ConvertToBase7(num));
    }
}