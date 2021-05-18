using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] arr = {3, 5, 1};
        bool expected = true;
        Assert.AreEqual(expected, s.CanMakeArithmeticProgression(arr));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {1, 2, 4};
        bool expected = false;
        Assert.AreEqual(expected, s.CanMakeArithmeticProgression(arr));
    }
}