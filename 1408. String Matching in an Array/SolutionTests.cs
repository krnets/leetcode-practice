using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string[] words = {"mass", "as", "hero", "superhero"};
        string[] expected = {"as", "hero"};
        Assert.Equal(expected, new Solution().StringMatching(words));
    }

    [Fact]
    public void ExampleTest2()
    {
        string[] words = {"leetcode", "et", "code"};
        string[] expected = {"et", "code"};
        Assert.Equal(expected, new Solution().StringMatching(words));
    }

    [Fact]
    public void ExampleTest3()
    {
        string[] words = {"blue", "green", "bu"};
        string[] expected = { };
        Assert.Equal(expected, new Solution().StringMatching(words));
    }

    [Fact]
    public void ExampleTest4()
    {
        string[] words = {"leetcoder", "leetcode", "od", "hamlet", "am"};
        string[] expected = {"leetcode", "od", "am"};
        Assert.Equal(expected, new Solution().StringMatching(words));
    }
}