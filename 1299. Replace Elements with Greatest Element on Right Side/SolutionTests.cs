using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] arr = {17, 18, 5, 4, 6, 1};
        int[] expected = {18, 6, 6, 6, 1, -1};
        Assert.AreEqual(expected, s.ReplaceElements(arr));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr = {400};
        int[] expected = {-1};
        Assert.AreEqual(expected, s.ReplaceElements(arr));
    }
}