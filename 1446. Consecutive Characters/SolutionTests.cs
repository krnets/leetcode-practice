using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "leetcode";
        var expected = 2;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "abbcccddddeeeeedcba";
        var expected = 5;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "triplepillooooow";
        var expected = 5;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "hooraaaaaaaaaaay";
        var expected = 11;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = "tourist";
        var expected = 1;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }

    [Fact]
    public void ExampleTest6()
    {
        var input = "cc";
        var expected = 2;
        Assert.Equal(expected, new Solution().MaxPower(input));
    }
}