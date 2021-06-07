using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string s = "aba";
        string t = "baba";
        int expected = 6;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest2()
    {
        string s = "ab";
        string t = "bb";
        int expected = 3;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest3()
    {
        string s = "a";
        string t = "a";
        int expected = 0;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest4()
    {
        string s = "abe";
        string t = "bbc";
        int expected = 10;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest5()
    {
        string s = "computer";
        string t = "computation";
        int expected = 90;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest6()
    {
        string s = "amazon";
        string t = "google";
        int expected = 38;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest7()
    {
        string s = "input";
        string t = "output";
        int expected = 30;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest8()
    {
        string s = "abc";
        string t = "bbc";
        int expected = 9;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest9()
    {
        string s = "one";
        string t = "two";
        int expected = 8;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest10()
    {
        string s = "pass";
        string t = "fail";
        int expected = 17;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }

    [Test]
    public void ExampleTest11()
    {
        string s = "pass";
        string t = "pass";
        int expected = 12;
        Assert.AreEqual(expected, new Solution().CountSubstrings(s, t));
    }
}
