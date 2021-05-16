using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] digits = {1, 2, 3};
        int[] expected = {1, 2, 4};
        Assert.AreEqual(expected, s.PlusOne(digits));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] digits = {4, 3, 2, 1};
        int[] expected = {4, 3, 2, 2};
        Assert.AreEqual(expected, s.PlusOne(digits));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] digits = {0};
        int[] expected = {1};
        Assert.AreEqual(expected, s.PlusOne(digits));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] digits =
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7,
            9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6
        };
        int[] expected =
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7,
            9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7
        };
        Assert.AreEqual(expected, s.PlusOne(digits));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] digits = {9};
        int[] expected = {1,0};
        Assert.AreEqual(expected, s.PlusOne(digits));
    }
}