using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string[] ops = {"5", "2", "C", "D", "+"};
        int expected = 30;
        Assert.Equal(expected, new Solution().CalPoints(ops));
    }

    [Fact]
    public void ExampleTest2()
    {
        string[] ops = {"5", "-2", "4", "C", "D", "9", "+", "+"};
        int expected = 27;
        Assert.Equal(expected, new Solution().CalPoints(ops));
    }

    [Fact]
    public void ExampleTest3()
    {
        string[] ops = {"1"};
        int expected = 1;
        Assert.Equal(expected, new Solution().CalPoints(ops));
    }
}