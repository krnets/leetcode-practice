using System;
using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    private static void PrintResults(string input, int[] expected, int[] actual)
    {
        Console.WriteLine("input: ");
        Console.WriteLine(string.Join(" ", input.Select(ch => ch)));
        Console.WriteLine("expected: ");
        Console.WriteLine(string.Join(" ", expected));
        Console.WriteLine("actual: ");
        Console.WriteLine(string.Join(" ", actual));
    }

    [Test]
    public void ExampleTest1()
    {
        string input = "loveleetcode";
        char c = 'e';
        int[] expected = {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0};
        var actual = new Solution().ShortestToChar(input, c);
        PrintResults(input, expected, actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        string input = "aaab";
        char c = 'b';
        int[] expected = {3, 2, 1, 0};
        var actual = new Solution().ShortestToChar(input, c);
        PrintResults(input, expected, actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        string input = "aaba";
        char c = 'b';
        int[] expected = {2, 1, 0, 1};
        var actual = new Solution().ShortestToChar(input, c);
        PrintResults(input, expected, actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest4()
    {
        string input = "abba";
        char c = 'b';
        int[] expected = {1, 0, 0, 1};
        var actual = new Solution().ShortestToChar(input, c);
        PrintResults(input, expected, actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest5()
    {
        string input = "cizokxcijwbyspcfcqws";
        char c = 'c';
        int[] expected =
            {0, 1, 2, 3, 2, 1, 0, 1, 2, 3, 4, 3, 2, 1, 0, 1, 0, 1, 2, 3};
        var actual = new Solution().ShortestToChar(input, c);
        PrintResults(input, expected, actual);
        Assert.AreEqual(expected, actual);
    }
}