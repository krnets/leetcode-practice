using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "Hello how are you Contestant";
        int k = 4;
        var expected = "Hello how are you";
        Assert.AreEqual(expected, s.TruncateSentence(input, k));
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();
        var input = "What is the solution to this problem";
        int k = 4;
        var expected = "What is the solution";
        Assert.AreEqual(expected, s.TruncateSentence(input, k));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "chopper is not a tanuki";
        int k = 5;
        var expected = "chopper is not a tanuki";
        Assert.AreEqual(expected, s.TruncateSentence(input, k));
    }
}