using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] bits = {1, 0, 0};
        Assert.True(new Solution().IsOneBitCharacter(bits));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] bits = {1, 1, 1, 0};
        Assert.False(new Solution().IsOneBitCharacter(bits));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] bits = {1, 0, 1, 0, 1, 0};
        Assert.False(new Solution().IsOneBitCharacter(bits));
    }
}