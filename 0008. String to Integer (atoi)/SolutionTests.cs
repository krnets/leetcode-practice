using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "42";
        var expected = 42;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "      -42";
        var expected = -42;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "4193 with words";
        var expected = 4193;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "words and 987";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "-91283472332";
        var expected = -2147483648;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest6()
    {
        var input = "";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest7()
    {
        var input = "+1";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest8()
    {
        var input = "3.14159";
        var expected = 3;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest9()
    {
        var input = "21474836460";
        var expected = 2147483647;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }


    [Test]
    public void ExampleTest10()
    {
        var input = " ";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest11()
    {
        var input = "-2147483648";
        var expected = -2147483648;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest12()
    {
        var input = "20000000000000000000";
        var expected = 2147483647;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest13()
    {
        var input = "  0000000000012345678";
        var expected = 12345678;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest14()
    {
        var input = "00000-42a1234";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }


    [Test]
    public void ExampleTest15()
    {
        var input = "000000000000000000";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest16()
    {
        var input = "-000000000000001";
        var expected = -1;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest17()
    {
        var input = "+-12";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest18()
    {
        var input = "1";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest19()
    {
        var input = "+";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest20()
    {
        var input = "    +0a32";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest21()
    {
        var input =
            "10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000522545459";
        var expected = 2147483647;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }

    [Test]
    public void ExampleTest22()
    {
        var input = "2147483648";
        var expected = 2147483647;
        Assert.AreEqual(expected, new Solution().MyAtoi(input));
    }
}