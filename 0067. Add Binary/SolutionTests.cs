using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var a = "11";
        var b = "1";
        var expected = "100";
        Assert.AreEqual(expected, s.AddBinary(a, b));
    }

    [Test]
    public void ExampleTest2()
    {
        var a = "1010";
        var b = "1011";
        var expected = "10101";
        Assert.AreEqual(expected, s.AddBinary(a, b));
    }

    [Test]
    public void ExampleTest3()
    {
        var a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
        var b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";
        var expected =
            "110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000";
        Assert.AreEqual(expected, s.AddBinary(a, b));
    }
}