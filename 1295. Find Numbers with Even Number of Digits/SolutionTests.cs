using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {12, 345, 2, 6, 7896};
        var expected = 2;
        Assert.AreEqual(expected, s.FindNumbers(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {555, 901, 482, 1771};
        var expected = 1;
        Assert.AreEqual(expected, s.FindNumbers(input));
    }
}