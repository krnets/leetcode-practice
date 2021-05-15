using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string[][] paths = {new[] {"London", "New York"}, new[] {"New York", "Lima"}, new[] {"Lima", "Sao Paulo"}};
        var expected = "Sao Paulo";
        Assert.AreEqual(expected, s.DestCity(paths));
    }

    [Test]
    public void ExampleTest2()
    {
        string[][] paths = {new[] {"B", "C"}, new[] {"D", "B"}, new[] {"C", "A"}};
        var expected = "A";
        Assert.AreEqual(expected, s.DestCity(paths));
    }
    [Test]
    public void ExampleTest3()
    {
        string[][] paths = {new[] {"A","Z" } };
        var expected = "Z";
        Assert.AreEqual(expected, s.DestCity(paths));
    }

}