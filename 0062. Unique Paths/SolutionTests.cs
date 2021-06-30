using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int m = 3;
        int n = 7;
        int expected = 28;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }

    [Fact]
    public void ExampleTest2()
    {
        int m = 3;
        int n = 2;
        int expected = 3;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }

    [Fact]
    public void ExampleTest3()
    {
        int m = 7;
        int n = 3;
        int expected = 28;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }

    [Fact]
    public void ExampleTest4()
    {
        int m = 3;
        int n = 3;
        int expected = 6;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }

    [Fact]
    public void ExampleTest5()
    {
        int m = 1;
        int n = 2;
        int expected = 1;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }

    [Fact]
    public void ExampleTest6()
    {
        int m = 23;
        int n = 12;
        int expected = 193536720;
        Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }
}