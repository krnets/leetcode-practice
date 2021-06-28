using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] flowerbed = {1, 0, 0, 0, 1};
        int n = 1;
        Assert.True(new Solution().CanPlaceFlowers(flowerbed, n));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] flowerbed = {1, 0, 0, 0, 1};
        int n = 2;
        Assert.False(new Solution().CanPlaceFlowers(flowerbed, n));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] flowerbed = {1, 0, 0, 0, 1, 0, 0};
        int n = 2;
        Assert.True(new Solution().CanPlaceFlowers(flowerbed, n));
    }
}