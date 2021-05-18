using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int input = 34;
        int k = 6;
        int expected = 9;
        Assert.AreEqual(expected, s.SumBase(input, k));
    }

    [Test]
    public void ExampleTest2()
    {
        int input = 10;
        int k = 10;
        int expected = 1;
        Assert.AreEqual(expected, s.SumBase(input, k));
    }
}