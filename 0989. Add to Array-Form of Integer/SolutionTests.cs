using Xunit;
using Xunit.Abstractions;

public class SolutionTests
{
    public SolutionTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    private readonly ITestOutputHelper _testOutputHelper;

    [Fact]
    public void ExampleTest1()
    {
        int[] num = {1, 2, 0, 0};
        int k = 34;
        int[] expected = {1, 2, 3, 4};
        Assert.Equal(expected, new Solution().AddToArrayForm(num, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] num = {2, 7, 4};
        int k = 181;
        int[] expected = {4, 5, 5};
        Assert.Equal(expected, new Solution().AddToArrayForm(num, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] num = {2, 1, 5};
        int k = 806;
        int[] expected = {1, 0, 2, 1};
        Assert.Equal(expected, new Solution().AddToArrayForm(num, k));
    }


    [Fact]
    public void ExampleTest4()
    {
        int[] num = {9, 9, 9, 9, 9, 9, 9, 9, 9, 9};
        int k = 1;
        int[] expected = {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        Assert.Equal(expected, new Solution().AddToArrayForm(num, k));
    }


    [Fact]
    public void ExampleTest5()
    {
        int[] num = {1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3};
        int k = 516;
        int[] expected = {1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 5, 7, 9};
        var actual = new Solution().AddToArrayForm(num, k);
        _testOutputHelper.WriteLine(string.Join(",", actual));

        Assert.Equal(expected, actual);
    }
}