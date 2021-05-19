using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    private static void ConsoleWriteResults(string[] expectedStrArray, string[] actualStrArray)
    {
        Console.Write("expected: ");

        foreach (var str in expectedStrArray.OrderBy(x => x))
            Console.WriteLine(str);

        Console.WriteLine();

        Console.Write("actual: ");

        foreach (var str in actualStrArray.OrderBy(x => x))
            Console.WriteLine(str);
    }

    [Test]
    public void ExampleTest1()
    {
        Solution s = new();

        int[] nums = {1, 2, 2};
        int[][] expected =
        {
            new int[0],
            new[] {1},
            new[] {1, 2},
            new[] {1, 2, 2},
            new[] {2},
            new[] {2, 2}
        };
        var actual = s.SubsetsWithDup(nums);

        var expectedStrArray = expected
            .Select(x => string.Join(",", x)).ToArray();

        var actualStrArray = actual
            .Select(x => string.Join(",", x)).ToArray();

        ConsoleWriteResults(expectedStrArray, actualStrArray);

        // Assert.That(expectedStrArray.Union(actualStrArray).SequenceEqual(expectedStrArray));
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();

        int[] nums = {0};
        int[][] expected = {new int[0], new[] {0}};
        Assert.AreEqual(expected, s.SubsetsWithDup(nums));
    }
}