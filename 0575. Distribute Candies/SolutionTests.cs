using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] candyType = {1, 1, 2, 2, 3, 3};
        int expected = 3;
        Assert.Equal(expected, new Solution().DistributeCandies(candyType));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] candyType = {1, 1, 2, 3};
        int expected = 2;
        Assert.Equal(expected, new Solution().DistributeCandies(candyType));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] candyType = {6, 6, 6, 6};
        int expected = 1;
        Assert.Equal(expected, new Solution().DistributeCandies(candyType));
    }
}