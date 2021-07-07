using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] numbers = {2, 7, 11, 15};
        int target = 9;
        int[] expected = {1, 2};
        Assert.Equal(expected, new Solution().TwoSum(numbers, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] numbers = {2, 3, 4};
        int target = 6;
        int[] expected = {1, 3};
        Assert.Equal(expected, new Solution().TwoSum(numbers, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] numbers = {-1, 0};
        int target = -1;
        int[] expected = {1, 2};
        Assert.Equal(expected, new Solution().TwoSum(numbers, target));
    }
}