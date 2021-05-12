using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "1-23-45 6";
        var expected = "123-456";
        Assert.AreEqual(expected, s.ReformatNumber(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "123 4-567";
        var expected = "123-45-67";
        Assert.AreEqual(expected, s.ReformatNumber(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "123 4-5678";
        var expected = "123-456-78";
        Assert.AreEqual(expected, s.ReformatNumber(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "12";
        var expected = "12";
        Assert.AreEqual(expected, s.ReformatNumber(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "--17-5 229 35-39475 ";
        var expected = "175-229-353-94-75";
        Assert.AreEqual(expected, s.ReformatNumber(input));
    }
}
