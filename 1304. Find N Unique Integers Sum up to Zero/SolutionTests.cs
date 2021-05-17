using System.Collections.Generic;
using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 5;
        var expected = new HashSet<int[]>
        {
            new[] {-7, -1, 1, 3, 4},
            new[] {-5, -1, 1, 2, 3},
            new[] {-3, -1, 2, -2, 4}
        };

        Assert.AreEqual(expected, s.SumZero(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 5;
        var expected = new HashSet<int[]> {new[] {-1, 0, 1}};
        Assert.AreEqual(expected, s.SumZero(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 1;
        var expected = new HashSet<int[]> {new[] {0}};
        Assert.AreEqual(expected, s.SumZero(input));
    }
}