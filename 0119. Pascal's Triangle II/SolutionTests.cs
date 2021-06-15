using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int rowIndex = 3;
        int[] expected = {1, 3, 3, 1};
        Assert.Equal(expected, new Solution().GetRow(rowIndex));
    }

    [Fact]
    public void ExampleTest2()
    {
        int rowIndex = 0;
        int[] expected = {1};
        Assert.Equal(expected, new Solution().GetRow(rowIndex));
    }

    [Fact]
    public void ExampleTest3()
    {
        int rowIndex = 1;
        int[] expected = {1, 1};
        Assert.Equal(expected, new Solution().GetRow(rowIndex));
    }

    [Fact]
    public void ExampleTest4()
    {
        int rowIndex = 4;
        int[] expected = {1, 4, 6, 4, 1};
        Assert.Equal(expected, new Solution().GetRow(rowIndex));
    }
}