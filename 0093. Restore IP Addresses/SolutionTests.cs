using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string input = "25525511135";
        string[] expected = {"255.255.11.135", "255.255.111.35"};
        Assert.AreEqual(expected, s.RestoreIpAddresses(input));
    }

    [Test]
    public void ExampleTest2()
    {
        string input = "0000";
        string[] expected = {"0.0.0.0"};
        Assert.AreEqual(expected, s.RestoreIpAddresses(input));
    }

    [Test]
    public void ExampleTest3()
    {
        string input = "1111";
        string[] expected = {"1.1.1.1"};
        Assert.AreEqual(expected, s.RestoreIpAddresses(input));
    }

    [Test]
    public void ExampleTest4()
    {
        string input = "010010";
        string[] expected = {"0.10.0.10", "0.100.1.0"};
        Assert.AreEqual(expected, s.RestoreIpAddresses(input));
    }

    [Test]
    public void ExampleTest5()
    {
        string input = "101023";
        string[] expected = {"1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3"};

        Assert.AreEqual(expected, s.RestoreIpAddresses(input));
    }
}