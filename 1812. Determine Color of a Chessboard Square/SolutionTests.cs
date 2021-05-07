using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest01()
    {
        var input = "a1";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest02()
    {
        var input = "h3";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest03()
    {
        var input = "c7";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest04()
    {
        var input = "c2";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest05()
    {
        var input = "a2";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest06()
    {
        var input = "b1";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest07()
    {
        var input = "b2";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest08()
    {
        var input = "h8";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest09()
    {
        var input = "b7";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest10()
    {
        var input = "b8";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest11()
    {
        var input = "c7";
        var expected = false;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }

    [Test]
    public void ExampleTest12()
    {
        var input = "c8";
        var expected = true;
        Assert.AreEqual(expected, s.SquareIsWhite(input));
    }
}