using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] arr = {1, 2, 4, 4, 4, 4};
        int m = 1;
        int k = 3;
        Assert.True(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] arr = {1, 2, 1, 2, 1, 1, 1, 3};
        int m = 2;
        int k = 2;
        Assert.True(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] arr = {1, 2, 1, 2, 1, 3};
        int m = 2;
        int k = 3;
        Assert.False(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] arr = {1, 2, 3, 1, 2};
        int m = 2;
        int k = 2;
        Assert.False(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] arr = {2, 2, 2, 2};
        int m = 2;
        int k = 3;
        Assert.False(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] arr = {99, 9};
        int m = 1;
        int k = 3;
        Assert.False(new Solution().ContainsPattern(arr, m, k));
    }

    [Fact]
    public void ExampleTest7()
    {
        int[] arr = {2, 2};
        int m = 1;
        int k = 2;
        Assert.True(new Solution().ContainsPattern(arr, m, k));
    }
}