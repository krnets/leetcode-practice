using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "5F3Z-2e-9-w";
        int k = 4;
        var expected = "5F3Z-2E9W";
        Assert.Equal(expected, new Solution().LicenseKeyFormatting(input, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "2-5g-3-J";
        int k = 2;
        var expected = "2-5G-3J";
        Assert.Equal(expected, new Solution().LicenseKeyFormatting(input, k));
    }
}