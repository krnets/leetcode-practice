using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3};
        int first = 1;
        int[] expected = {1, 0, 2, 1};
        Assert.AreEqual(expected, s.Decode(input, first));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {6, 2, 7, 3};
        int first = 4;
        int[] expected = {4, 2, 0, 7, 4};
        Assert.AreEqual(expected, s.Decode(input, first));
    }
}