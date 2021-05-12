using NUnit.Framework;

public class SolutionTests
{
    Solution solution = new();

    [Test]
    public void ExampleTest1()
    {
        var s = "anagram";
        var t = "nagaram";
        var expected = true;
        Assert.AreEqual(expected, solution.IsAnagram(s, t));
    }

    [Test]
    public void ExampleTest2()
    {
        var s = "rat";
        var t = "car";
        var expected = false;
        Assert.AreEqual(expected, solution.IsAnagram(s, t));
    }
}