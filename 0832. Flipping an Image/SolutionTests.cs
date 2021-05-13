using System;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        Solution s = new();
        int[][] image = {new[] {1, 1, 0}, new[] {1, 0, 1}, new[] {0, 0, 0}};
        int[][] expected = {new[] {1, 0, 0}, new[] {0, 1, 0}, new[] {1, 1, 1}};
        var actual = s.FlipAndInvertImage(image);

        foreach (int[] row in actual)
        {
            foreach (int c in row)
                Console.Write($"{c} ");

            Console.WriteLine();
        }

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();
        int[][] image = {new[] {1, 1, 0, 0}, new[] {1, 0, 0, 1}, new[] {0, 1, 1, 1}, new[] {1, 0, 1, 0}};
        int[][] expected = {new[] {1, 1, 0, 0}, new[] {0, 1, 1, 0}, new[] {0, 0, 0, 1}, new[] {1, 0, 1, 0}};
        var actual = s.FlipAndInvertImage(image);

        foreach (int[] row in actual)
        {
            foreach (int c in row)
                Console.Write($"{c} ");

            Console.WriteLine();
        }

        Assert.AreEqual(expected, actual);
    }
}