using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest01()
    {
        var input = "0";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest02()
    {
        var input = ".1";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest03()
    {
        var input = "2";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest04()
    {
        var input = "0089";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest05()
    {
        var input = "-0.1";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest06()
    {
        var input = "+3.14";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest07()
    {
        var input = "4.";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest08()
    {
        var input = "-.9";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest09()
    {
        var input = "2e10";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest10()
    {
        var input = "-90E3";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest11()
    {
        var input = "3e+7";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest12()
    {
        var input = "+6e-1";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest13()
    {
        var input = "53.5e93";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest14()
    {
        var input = "-123.456e789";
        Assert.IsTrue(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest15()
    {
        var input = "e";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest16()
    {
        var input = ".";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest17()
    {
        var input = "abc";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest18()
    {
        var input = "1a";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest19()
    {
        var input = "1e";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest20()
    {
        var input = "e3";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest21()
    {
        var input = "99e2.5";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest22()
    {
        var input = "--6";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest23()
    {
        var input = "-+3";
        Assert.IsFalse(new Solution().IsNumber(input));
    }

    [Test]
    public void ExampleTest24()
    {
        var input = "95a54e53";
        Assert.IsFalse(new Solution().IsNumber(input));
    }
}