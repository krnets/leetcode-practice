using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int low = 3;
        int high = 7;
        int expected = 3;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }

    [Fact]
    public void ExampleTest2()
    {
        int low = 8;
        int high = 10;
        int expected = 1;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }

    [Fact]
    public void ExampleTest3()
    {
        int low = 21;
        int high = 22;
        int expected = 1;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }

    [Fact]
    public void ExampleTest4()
    {
        int low = 14;
        int high = 17;
        int expected = 2;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }

    [Fact]
    public void ExampleTest5()
    {
        int low = 143236945;
        int high = 336864988;
        int expected = 96814022;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }

    [Fact]
    public void ExampleTest6()
    {
        int low = 278382788;
        int high = 569302584;
        int expected = 145459898;
        Assert.Equal(expected, new Solution().CountOdds(low, high));
    }
}