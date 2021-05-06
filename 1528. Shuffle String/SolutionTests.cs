using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var str = "codeleet";
        int[] input = {4, 5, 6, 7, 0, 2, 1, 3};
        var expected = "leetcode";
        Assert.AreEqual(expected, s.RestoreString(str, input));
    }

    [Test]
    public void ExampleTest2()
    {
        var str = "abc";
        int[] input = {0, 1, 2};
        var expected = "abc";
        Assert.AreEqual(expected, s.RestoreString(str, input));
    }

    [Test]
    public void ExampleTest3()
    {
        var str = "aiohn";
        int[] input = {3, 1, 4, 2, 0};
        var expected = "nihao";
        Assert.AreEqual(expected, s.RestoreString(str, input));
    }

    [Test]
    public void ExampleTest4()
    {
        var str = "aaiougrt";
        int[] input = {4, 0, 2, 6, 7, 3, 1, 5};
        var expected = "arigatou";
        Assert.AreEqual(expected, s.RestoreString(str, input));
    }

    [Test]
    public void ExampleTest5()
    {
        var str = "art";
        int[] input = {1, 0, 2};
        var expected = "rat";
        Assert.AreEqual(expected, s.RestoreString(str, input));
    }
}