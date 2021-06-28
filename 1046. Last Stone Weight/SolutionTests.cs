using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] stones = {2, 7, 4, 1, 8, 1};
        var expected = 1;
        Assert.Equal(expected, new Solution().LastStoneWeight(stones));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] stones = {1, 3};
        var expected = 2;
        Assert.Equal(expected, new Solution().LastStoneWeight(stones));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] stones = {3, 7, 8};
        var expected = 2;
        Assert.Equal(expected, new Solution().LastStoneWeight(stones));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] stones = {9, 3, 2, 10};
        var expected = 0;
        Assert.Equal(expected, new Solution().LastStoneWeight(stones));
    }
}