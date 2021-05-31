using System;
using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums1 = {1, 2, 2, 1};
        int[] nums2 = {2, 2};
        int[][] expected = {new[] {2}};
        int[] actual = new Solution().Intersection(nums1, nums2);
        Console.WriteLine(string.Join(", ", actual));
        Assert.IsTrue(expected.Any(x => x.SequenceEqual(actual)));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums1 = {4, 9, 5};
        int[] nums2 = {9, 4, 9, 8, 4};
        int[][] expected = {new[] {4, 9}, new[] {9, 4}};
        int[] actual = new Solution().Intersection(nums1, nums2);
        Console.WriteLine(string.Join(", ", actual));
        Assert.IsTrue(expected.Any(x => x.SequenceEqual(actual)));
    }
}