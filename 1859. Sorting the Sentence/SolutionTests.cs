using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "is2 sentence4 This1 a3";
        var expected = "This is a sentence";
        Assert.AreEqual(expected, s.SortSentence(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "Myself2 Me1 I4 and3";
        var expected = "Me Myself and I";
        Assert.AreEqual(expected, s.SortSentence(input));
    }
}