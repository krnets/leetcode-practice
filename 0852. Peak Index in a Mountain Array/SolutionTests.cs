using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] arr = {0, 1, 0};
        int expected = 1;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] arr = {0, 2, 1, 0};
        int expected = 1;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] arr = {0, 10, 5, 2};
        int expected = 1;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] arr = {3, 4, 5, 1};
        int expected = 2;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] arr = {24, 69, 100, 99, 79, 78, 67, 36, 26, 19};
        int expected = 2;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] arr = {3, 4, 5, 4, 6, 1};
        int expected = 2;
        Assert.Equal(expected, new Solution().PeakIndexInMountainArray(arr));
    }
}