using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var text = "  this   is  a sentence ";
        var expected = "this   is   a   sentence";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }

    [Fact]
    public void ExampleTest2()
    {
        var text = " practice   makes   perfect";
        var expected = "practice   makes   perfect ";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }

    [Fact]
    public void ExampleTest3()
    {
        var text = "hello   world";
        var expected = "hello   world";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }

    [Fact]
    public void ExampleTest4()
    {
        var text = "  walks  udp package   into  bar a";
        var expected = "walks  udp  package  into  bar  a ";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }

    [Fact]
    public void ExampleTest5()
    {
        var text = "a";
        var expected = "a";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }

    [Fact]
    public void ExampleTest6()
    {
        var text = "  hello";
        var expected = "hello  ";
        Assert.Equal(expected, new Solution().ReorderSpaces(text));
    }
}