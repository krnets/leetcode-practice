using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int input = 13;
        int expected = 4;
        Assert.Equal(expected, new Solution().CountLargestGroup(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        int input = 2;
        int expected = 2;
        Assert.Equal(expected, new Solution().CountLargestGroup(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        int input = 15;
        int expected = 6;
        Assert.Equal(expected, new Solution().CountLargestGroup(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        int input = 24;
        int expected = 5;
        Assert.Equal(expected, new Solution().CountLargestGroup(input));
    }
}