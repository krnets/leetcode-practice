using System;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[][] matrix =
        {
            new[] {3, 7, 8}, 
            new[] {9, 11, 13}, 
            new[] {15, 16, 17}
        };
        int[] expected = {15};
        Assert.AreEqual(expected, new Solution().LuckyNumbers(matrix));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] matrix =
        {
            new[] {1,  10,  4,  2}, 
            new[] {9,   3,  8,  7}, 
            new[] {15, 16, 17, 12}
        };
        int[] expected = {12};
        var actual = new Solution().LuckyNumbers(matrix);
        Console.WriteLine(string.Join(", ", actual));
        Assert.AreEqual(expected,actual );
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] matrix =
        {
            new[] {7, 8}, new[] {1, 2}
        };
        int[] expected = {7};
        Assert.AreEqual(expected, new Solution().LuckyNumbers(matrix));
    }
}