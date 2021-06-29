using System.Linq;
using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] groupSizes = {3, 3, 3, 3, 3, 1, 3};
        int[][] arr1 = {new[] {5}, new[] {0, 1, 2}, new[] {3, 4, 6}};
        int[][] arr2 = {new[] {5}, new[] {0, 4, 2}, new[] {2, 4, 6}};
        int[][] arr3 = {new[] {5}, new[] {0, 6, 2}, new[] {4, 3, 1}};
        var expected = new[] {arr1, arr2, arr3};
        var actual = new Solution().GroupThePeople(groupSizes);

        bool any = false;

        foreach (var arr in expected)
        {
            if (arr.All(x => actual.Any(x.SequenceEqual)))
            {
                any = true;
                break;
            }
        }

        Assert.True(any);
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] groupSizes = {2, 1, 3, 3, 3, 2};
        int[][] expected = {new[] {1}, new[] {0, 5}, new[] {2, 3, 4}};
        var actual = new Solution().GroupThePeople(groupSizes);
        bool all = expected.All(x => actual.Any(x.SequenceEqual));

        Assert.True(all);
    }
}