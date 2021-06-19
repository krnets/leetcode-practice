using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] deck = {1, 2, 3, 4, 4, 3, 2, 1};
        Assert.True(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] deck = {1, 1, 1, 2, 2, 2, 3, 3};
        Assert.False(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] deck = {1};
        Assert.False(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] deck = {1, 1};
        Assert.True(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] deck = {1, 1, 2, 2, 2, 2};
        Assert.True(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] deck = {0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 3, 3, 4, 5, 6};
        Assert.False(new Solution().HasGroupsSizeX(deck));
    }

    [Fact]
    public void ExampleTest7()
    {
        int[] deck =
            {0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3};
        Assert.True(new Solution().HasGroupsSizeX(deck));
    }
}