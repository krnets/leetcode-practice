using System.Linq;
using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int n = 2;
        int[][] expected =
        {
            new[] {0, 1, 3, 2},
            new[] {0, 2, 3, 1}
        };
        var actual = new Solution().GrayCode(n);
        Assert.True(expected.Any(x => x.SequenceEqual(actual)));
    }

    [Fact]
    public void ExampleTest2()
    {
        int n = 1;
        int[] expected = {0, 1};
        var actual = new Solution().GrayCode(n);
        Assert.True(expected.SequenceEqual(actual));
    }
}