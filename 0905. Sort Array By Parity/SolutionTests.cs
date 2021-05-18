using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 1, 2, 4};
        int[][] validArrays =
        {
            new[] {2, 4, 3, 1},
            new[] {4, 2, 3, 1},
            new[] {2, 4, 1, 3},
            new[] {4, 2, 1, 3}
        };
        var actual = s.SortArrayByParity(nums);

        Assert.That(validArrays.Any(l => l.SequenceEqual(actual)));
    }
}