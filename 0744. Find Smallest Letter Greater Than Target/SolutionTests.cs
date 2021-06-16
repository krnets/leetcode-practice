using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        char[] letters = {'c', 'f', 'j'};
        char target = 'a';
        var expected = 'c';
        Assert.Equal(expected, new Solution().NextGreatestLetter(letters, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        char[] letters = {'c', 'f', 'j'};
        char target = 'c';
        var expected = 'f';
        Assert.Equal(expected, new Solution().NextGreatestLetter(letters, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        char[] letters = {'c', 'f', 'j'};
        char target = 'd';
        var expected = 'f';
        Assert.Equal(expected, new Solution().NextGreatestLetter(letters, target));
    }

    [Fact]
    public void ExampleTest4()
    {
        char[] letters = {'c', 'f', 'j'};
        char target = 'g';
        var expected = 'j';
        Assert.Equal(expected, new Solution().NextGreatestLetter(letters, target));
    }

    [Fact]
    public void ExampleTest5()
    {
        char[] letters = {'c', 'f', 'j'};
        char target = 'j';
        var expected = 'c';
        Assert.Equal(expected, new Solution().NextGreatestLetter(letters, target));
    }
}