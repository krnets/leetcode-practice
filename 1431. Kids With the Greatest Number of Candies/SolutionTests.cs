using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {2, 3, 5, 1, 3};
        int candies = 3;
        bool[] expected = {true, true, true, false, true};
        Assert.AreEqual(expected, s.KidsWithCandies(input, candies));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {4, 2, 1, 1, 2};
        int candies = 1;
        bool[] expected = {true, false, false, false, false};
        Assert.AreEqual(expected, s.KidsWithCandies(input, candies));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {12, 1, 12};
        int candies = 10;
        bool[] expected = {true, false, true};
        Assert.AreEqual(expected, s.KidsWithCandies(input, candies));
    }
}