using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string[] words = {"gin", "zen", "gig", "msg"};
        var expected = 2;
        Assert.AreEqual(expected, s.UniqueMorseRepresentations(words));
    }
}