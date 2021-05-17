using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[][] logs = {new[] {1993, 1999}, new[] {2000, 2010}};
        var expected = 1993;
        Assert.AreEqual(expected, s.MaximumPopulation(logs));
    }

    [Test]
    public void ExampleTest2()
    {
        int[][] logs = {new[] {1950, 1961}, new[] {1960, 1971}, new[] {1970, 1981}};
        var expected = 1960;
        Assert.AreEqual(expected, s.MaximumPopulation(logs));
    }

    [Test]
    public void ExampleTest3()
    {
        int[][] logs =
        {
            new[] {2033, 2034}, new[] {2039, 2047}, new[] {1998, 2042}, new[] {2047, 2048}, new[] {2025, 2029},
            new[] {2005, 2044}, new[] {1990, 1992}, new[] {1952, 1956}, new[] {1984, 2014}
        };
        var expected = 2005;
        Assert.AreEqual(expected, s.MaximumPopulation(logs));
    }

    [Test]
    public void ExampleTest4()
    {
        int[][] logs =
        {
            new[] {2025, 2041}, new[] {1988, 2007}, new[] {2003, 2046}, new[] {2045, 2049}, new[] {2025, 2027},
            new[] {2014, 2040}, new[] {2014, 2027}, new[] {2011, 2027}, new[] {1972, 2019}
        };
        var expected = 2025;
        Assert.AreEqual(expected, s.MaximumPopulation(logs));
    }
}