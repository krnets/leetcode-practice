using System;
using System.Collections.Generic;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    private static void PrintResultsComparison(int[] nums, IEnumerable<int> expected, int[] actual)
    {
        Console.WriteLine("original: ");
        Console.WriteLine(string.Join(" ", nums));
        Console.WriteLine("expected: ");
        Console.WriteLine(string.Join(" ", expected));
        Console.WriteLine("actual: ");
        Console.WriteLine(string.Join(" ", actual));
    }

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 1, 1, 2, 2, 3};
        int k = 2;
        var expected = new HashSet<int> {1, 2};
        var actual = new Solution().TopKFrequent(nums, k);
        PrintResultsComparison(nums, expected, actual);
        Assert.IsTrue(expected.Overlaps(actual));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1};
        int k = 1;
        var expected = new HashSet<int> {1};
        var actual = new Solution().TopKFrequent(nums, k);
        PrintResultsComparison(nums, expected, actual);
        Assert.IsTrue(expected.Overlaps(actual));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {4, 1, -1, 2, -1, 2, 3};
        int k = 2;
        var expected = new HashSet<int> {-1, 2};
        var actual = new Solution().TopKFrequent(nums, k);
        PrintResultsComparison(nums, expected, actual);
        Assert.IsTrue(expected.Overlaps(actual));
    }
}