using System;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    private static void PrintResultsComparison(int[] nums, int[] expected, int[] actual)
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
        int[] nums = {1, 1, 2, 2, 2, 3};
        int[] expected = {3, 1, 1, 2, 2, 2};
        var actual = new Solution().FrequencySort(nums);
        PrintResultsComparison(nums, expected, actual);
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void ExampleTest2()
    {
        int[] nums = {2, 3, 1, 3, 2};
        int[] expected = {1, 3, 3, 2, 2};
        var actual = new Solution().FrequencySort(nums);
        PrintResultsComparison(nums, expected, actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {-1, 1, -6, 4, 5, -6, 1, 4, 1};
        int[] expected = {5, -1, 4, 4, -6, -6, 1, 1, 1};
        var actual = new Solution().FrequencySort(nums);
        PrintResultsComparison(nums, expected, actual);
        Assert.AreEqual(expected, actual);
    }
}