using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "Hello, my name is John";
        var expected = 5;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "Hello";
        var expected = 1;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "love live! mu'sic forever";
        var expected = 4;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "";
        var expected = 0;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = "                ";
        var expected = 0;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest6()
    {
        var input = "Of all the gin joints in all the towns in all the world,   ";
        var expected = 13;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest7()
    {
        var input = ", , , ,        a, eaefa";
        var expected = 6;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }

    [Fact]
    public void ExampleTest8()
    {
        var input =
            "The one-hour drama series Westworld is a dark odyssey about the dawn of artificial consciousness and the evolution of sin. Set at the intersection of the near future and the reimagined past, it explores a world in which every human appetite, no matter how noble or depraved, can be indulged.";

        var expected = 50;
        Assert.Equal(expected, new Solution().CountSegments(input));
    }
}