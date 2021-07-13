using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int n = 3;
        int a = 2;
        int b = 3;
        int c = 5;
        int expected = 4;
        Assert.Equal(expected, new Solution().NthUglyNumber(n, a, b, c));
    }

    [Fact]
    public void ExampleTest2()
    {
        int n = 4;
        int a = 2;
        int b = 3;
        int c = 4;
        int expected = 6;
        Assert.Equal(expected, new Solution().NthUglyNumber(n, a, b, c));
    }

    [Fact]
    public void ExampleTest3()
    {
        int n = 5;
        int a = 2;
        int b = 11;
        int c = 13;
        int expected = 10;
        Assert.Equal(expected, new Solution().NthUglyNumber(n, a, b, c));
    }

    [Fact]
    public void ExampleTest4()
    {
        int n = 1000000000;
        int a = 2;
        int b = 217983653;
        int c = 336916467;
        int expected = 1999999984;
        Assert.Equal(expected, new Solution().NthUglyNumber(n, a, b, c));
    }
}