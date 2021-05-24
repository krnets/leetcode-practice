using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] arr = {1, 3, 4, 8};
        int[][] queries = {new[] {0, 1}, new[] {1, 2}, new[] {0, 3}, new[] {3, 3}};
        int[] expected = {2, 7, 14, 8};
        Assert.AreEqual(expected, new Solution().XorQueries(arr, queries));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {4, 8, 2, 10};
        int[][] queries = {new[] {2, 3}, new[] {1, 3}, new[] {0, 0}, new[] {0, 3}};
        int[] expected = {8, 0, 4, 4};
        Assert.AreEqual(expected, new Solution().XorQueries(arr, queries));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] arr = {16};
        int[][] queries = {new[] {0, 0}, new[] {0, 0}, new[] {0, 0}};
        int[] expected = {16, 16, 16};
        Assert.AreEqual(expected, new Solution().XorQueries(arr, queries));
    }
}