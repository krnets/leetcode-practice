using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] arr = {3, 3, 3, 3, 5, 5, 5, 2, 2, 7};
        int expected = 2;
        Assert.Equal(expected, new Solution().MinSetSize(arr));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] arr = {7, 7, 7, 7, 7, 7};
        int expected = 1;
        Assert.Equal(expected, new Solution().MinSetSize(arr));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] arr = {1, 9};
        int expected = 1;
        Assert.Equal(expected, new Solution().MinSetSize(arr));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] arr = {1000, 1000, 3, 7};
        int expected = 1;
        Assert.Equal(expected, new Solution().MinSetSize(arr));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int expected = 5;
        Assert.Equal(expected, new Solution().MinSetSize(arr));
    }
}