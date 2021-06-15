using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string[] logs = {"d1/", "d2/", "../", "d21/", "./"};
        int expected = 2;
        Assert.Equal(expected, new Solution().MinOperations(logs));
    }

    [Fact]
    public void ExampleTest2()
    {
        string[] logs = {"d1/", "d2/", "./", "d3/", "../", "d31/"};
        int expected = 3;
        Assert.Equal(expected, new Solution().MinOperations(logs));
    }

    [Fact]
    public void ExampleTest3()
    {
        string[] logs = {"d1/", "../", "../", "../"};
        int expected = 0;
        Assert.Equal(expected, new Solution().MinOperations(logs));
    }
}