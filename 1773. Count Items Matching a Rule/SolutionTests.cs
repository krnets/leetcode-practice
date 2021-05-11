using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string[][] items =
        {
            new[] {"phone", "blue", "pixel"},
            new[] {"computer", "silver", "lenovo"},
            new[] {"phone", "gold", "iphone"}
        };
        var ruleKey = "color";
        var ruleValue = "silver";
        var expected = 1;
        Assert.AreEqual(expected, s.CountMatches(items, ruleKey, ruleValue));
    }

    [Test]
    public void ExampleTest2()
    {
        string[][] items =
        {
            new[] {"phone", "blue", "pixel"},
            new[] {"computer", "silver", "phone"},
            new[] {"phone", "gold", "iphone"},
        };
        var ruleKey = "type";
        var ruleValue = "phone";
        var expected = 2;
        Assert.AreEqual(expected, s.CountMatches(items, ruleKey, ruleValue));
    }
}