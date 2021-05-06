using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "thequickbrownfoxjumpsoverthelazydog";
        var expected = true;
        Assert.AreEqual(expected, s.CheckIfPangram(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "leetcode";
        var expected = false;
        Assert.AreEqual(expected, s.CheckIfPangram(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input =
            "onrcsnlxckptsxffbyswujpamfltvmdoxovggepknmtacrjkkorjgvgtgaiaudspnpxkwikevmjeephhiyvnoymjwjfopovscbefecnoytjxfwasabwohqujwowmakpyuuqvgfab";
        var expected = false;
        Assert.AreEqual(expected, s.CheckIfPangram(input));
    }
}