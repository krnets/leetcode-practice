using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 4, 2, 5, 3};
        var expected = 58;
        Assert.AreEqual(expected, s.SumOddLengthSubarrays(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2};
        var expected = 3;
        Assert.AreEqual(expected, s.SumOddLengthSubarrays(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {10, 11, 12};
        var expected = 66;
        Assert.AreEqual(expected, s.SumOddLengthSubarrays(input));
    }
}