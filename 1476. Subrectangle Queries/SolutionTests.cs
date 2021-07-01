using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] rectangle =
        {
            new[] {1, 2, 1},
            new[] {4, 3, 4},
            new[] {3, 2, 1},
            new[] {1, 1, 1}
        };
        var sq = new SubrectangleQueries(rectangle);
        // The initial rectangle (4x3) looks like:
        // 1 2 1
        // 4 3 4
        // 3 2 1
        // 1 1 1
        Assert.Equal(1, sq.GetValue(0, 2)); // return 1

        sq.UpdateSubrectangle(0, 0, 3, 2, 5);
        // After this update the rectangle looks like:
        // 5 5 5
        // 5 5 5
        // 5 5 5
        // 5 5 5 
        Assert.Equal(5, sq.GetValue(0, 2)); // return 5
        Assert.Equal(5, sq.GetValue(3, 1)); // return 5

        sq.UpdateSubrectangle(3, 0, 3, 2, 10);
        // After this update the rectangle looks like:
        // 5   5   5
        // 5   5   5
        // 5   5   5
        // 10  10  10 
        Assert.Equal(10, sq.GetValue(3, 1)); // return 10
        Assert.Equal(5, sq.GetValue(0, 2)); // return 5
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] rectangle =
        {
            new[] {1, 1, 1},
            new[] {2, 2, 2},
            new[] {3, 3, 3},
        };
        var sq = new SubrectangleQueries(rectangle);
        // The initial rectangle (3x3) looks like:
        // 1 1 1
        // 2 2 2
        // 3 3 3

        Assert.Equal(1, sq.GetValue(0, 0));

        sq.UpdateSubrectangle(0, 0, 2, 2, 100);
        // After this update the rectangle looks like:
        // 100 100 100
        // 100 100 100
        // 100 100 100
        Assert.Equal(100, sq.GetValue(0, 0));
        Assert.Equal(100, sq.GetValue(2, 2));

        sq.UpdateSubrectangle(1, 1, 2, 2, 20);
        // After this update the rectangle looks like:
        // 100 100 100
        // 100 20  20
        // 100 20  20
        Assert.Equal(20, sq.GetValue(2, 2));
    }
}