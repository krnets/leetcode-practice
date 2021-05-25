using System;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    private static void PrintResultsComparison(int[] expected, int[] actual)
    {
        Console.WriteLine("expected:");
        Console.WriteLine(string.Join(" ", expected));
        Console.WriteLine("actual:");
        Console.WriteLine(string.Join(" ", actual));
    }

    [Test]
    public void ExampleTest1()
    {
        int[] temperatures = {73, 74, 75, 71, 69, 72, 76, 73};
        int[] expected = {1, 1, 4, 2, 1, 1, 0, 0};
        int[] actual = new Solution().DailyTemperatures(temperatures);
        PrintResultsComparison(expected, actual);
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void ExampleTest2()
    {
        int[] temperatures = {55, 38, 53, 81, 61, 93, 97, 32, 43, 78};
        int[] expected = {3, 1, 1, 2, 1, 1, 0, 1, 1, 0};
        int[] actual = new Solution().DailyTemperatures(temperatures);
        PrintResultsComparison(expected, actual);
        Assert.AreEqual(expected, actual);
    }
}