using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "abbaca";
        var expected = "ca";
        Assert.Equal(expected, new Solution().RemoveDuplicates(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "azxxzy";
        var expected = "ay";
        Assert.Equal(expected, new Solution().RemoveDuplicates(input));
    }
}