using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {4, 2, 5, 7};
        int[][] expected =
        {
            new[] {4, 7, 2, 5},
            new[] {2, 5, 4, 7},
            new[] {2, 7, 4, 5},
            new[] {4, 5, 2, 7}
        };
        int[] actual = new Solution().SortArrayByParityII(nums);
        Assert.IsTrue(expected.Any(x => x.SequenceEqual(actual)));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {2, 3};
        int[][] expected =
        {
            new[] {2, 3},
        };
        int[] actual = new Solution().SortArrayByParityII(nums);
        Assert.IsTrue(expected.Any(x => x.SequenceEqual(actual)));
    }
}