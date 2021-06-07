using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int rows = 1;
        int cols = 2;
        int rCenter = 0;
        int cCenter = 0;
        int[][] expected = {new[] {0, 0}, new[] {0, 1}};

        Assert.AreEqual(expected, new Solution().AllCellsDistOrder(rows, cols, rCenter, cCenter));
    }

    [Test]
    public void ExampleTest2()
    {
        int rows = 2;
        int cols = 2;
        int rCenter = 0;
        int cCenter = 1;
        int[][] expected =
        {
            new[] {0, 1},
            new[] {0, 0},
            new[] {1, 1},
            new[] {1, 0},
        };

        int[][] actual = new Solution().AllCellsDistOrder(rows, cols, rCenter, cCenter);

        var expectedStrArray = expected
            .Select(x => string.Join(",", x))
            .OrderBy(x => x);

        var actualStrArray = actual
            .Select(x => string.Join(",", x))
            .OrderBy(x => x);

        Assert.IsTrue(actualStrArray.SequenceEqual(expectedStrArray));
    }

    [Test]
    public void ExampleTest3()
    {
        int rows = 2;
        int cols = 3;
        int rCenter = 1;
        int cCenter = 2;
        int[][] expected =
        {
            new[] {1, 2},
            new[] {0, 2},
            new[] {1, 1},
            new[] {0, 1},
            new[] {1, 0},
            new[] {0, 0}
        };
        int[][] actual = new Solution().AllCellsDistOrder(rows, cols, rCenter, cCenter);

        var expectedStrArray = expected
            .Select(x => string.Join(",", x))
            .OrderBy(x => x);

        var actualStrArray = actual
            .Select(x => string.Join(",", x))
            .OrderBy(x => x);

        Assert.IsTrue(actualStrArray.SequenceEqual(expectedStrArray));
    }
}