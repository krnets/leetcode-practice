using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int n = 3;
        string[] expected = {"1", "2", "Fizz"};
        Assert.Equal(expected, new Solution().FizzBuzz(n));
    }

    [Fact]
    public void ExampleTest2()
    {
        int n = 3;
        string[] expected = {"1", "2", "Fizz"};
        Assert.Equal(expected, new Solution().FizzBuzz(n));
    }

    [Fact]
    public void ExampleTest3()
    {
        int n = 3;
        string[] expected = {"1", "2", "Fizz"};
        Assert.Equal(expected, new Solution().FizzBuzz(n));
    }

    [Fact]
    public void ExampleTest4()
    {
        int n = 15;
        string[] expected =
            {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
        Assert.Equal(expected, new Solution().FizzBuzz(n));
    }
}