using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var num1 = "2";
        var num2 = "3";
        var expected = "6";
        Assert.AreEqual(expected, s.Multiply(num1, num2));
    }

    [Test]
    public void ExampleTest2()
    {
        var num1 = "123";
        var num2 = "456";
        var expected = "56088";
        Assert.AreEqual(expected, s.Multiply(num1, num2));
    }

    [Test]
    public void ExampleTest3()
    {
        var num1 = "498828660196";
        var num2 = "840477629533";
        var expected = "419254329864656431168468";
        Assert.AreEqual(expected, s.Multiply(num1, num2));
    }

    [Test]
    public void ExampleTest4()
    {
        var num1 = "401716832807512840963";
        var num2 = "167141802233061013023557397451289113296441069";
        var expected = "67143675422804947379429215144664313370120390398055713625298709447";
        Assert.AreEqual(expected, s.Multiply(num1, num2));
    }

    [Test]
    public void ExampleTest5()
    {
        var num1 = "1";
        var num2 = "0";
        var expected = "0";
        Assert.AreEqual(expected, s.Multiply(num1, num2));
    }
}