using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "G()(al)";
        var expected = "Goal";
        Assert.AreEqual(expected, s.Interpret(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "G()()()()(al)";
        var expected = "Gooooal";
        Assert.AreEqual(expected, s.Interpret(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "(al)G(al)()()G";
        var expected = "alGalooG";
        Assert.AreEqual(expected, s.Interpret(input));
    }
}