using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {5, 7, 7, 8, 8, 10};
        int target = 8;
        int[] expected = {3, 4};
        Assert.AreEqual(expected, s.SearchRange(input, target));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {5, 7, 7, 8, 8, 10};
        int target = 6;
        int[] expected = {-1, -1};
        Assert.AreEqual(expected, s.SearchRange(input, target));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = { };
        int target = 0;
        int[] expected = {-1, -1};
        Assert.AreEqual(expected, s.SearchRange(input, target));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] input = {1};
        int target = 1;
        int[] expected = {0, 0};
        Assert.AreEqual(expected, s.SearchRange(input, target));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] input = {1, 3};
        int target = 1;
        int[] expected = {0, 0};
        Assert.AreEqual(expected, s.SearchRange(input, target));
    }
}