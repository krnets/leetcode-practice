using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] arr1 = {2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19};
        int[] arr2 = {2, 1, 4, 3, 9, 6};
        int[] expected = {2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19};
        Assert.AreEqual(expected, new Solution().RelativeSortArray(arr1, arr2));
    }
}