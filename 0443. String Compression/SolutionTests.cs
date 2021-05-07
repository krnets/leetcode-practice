using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        char[] input = {'a', 'a', 'b', 'b', 'c', 'c', 'c'};
        // char[] expected = {'a', '2', 'b', '2', 'c', '3'};
        int expected = 6;
        Assert.AreEqual(expected, s.Compress(input));
        // var result = s.Compress(input);
        // Console.WriteLine(expected);
        // Console.WriteLine(new string('-', result.Length));
        // Console.WriteLine(result);
        // Assert.AreEqual(expected, result);
    }

    [Test]
    public void ExampleTest2()
    {
        char[] input = {'a'};
        // char[] expected = {'a'};
        int expected = 1;
        Assert.AreEqual(expected, s.Compress(input));
        // var result = s.Compress(input);
        // Console.WriteLine(expected);
        // Console.WriteLine(new string('-', result.Length));
        // Console.WriteLine(result);
        // Assert.AreEqual(expected, result);
    }

    [Test]
    public void ExampleTest3()
    {
        char[] input = {'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'};
        // char[] expected = {'a', 'b', '1', '2'};
        int expected = 4;
        Assert.AreEqual(expected, s.Compress(input));
        // var result = s.Compress(input);
        // Console.WriteLine(expected);
        // Console.WriteLine(new string('-', result.Length));
        // Console.WriteLine(result);
        // Assert.AreEqual(expected, result);
    }

    [Test]
    public void ExampleTest4()
    {
        char[] input = {'a', 'a', 'a', 'b', 'b', 'a', 'a'};
        // char[] expected = {'a', '3', 'b', '2', 'a', '2'};
        int expected = 6;
        Assert.AreEqual(expected, s.Compress(input));
        // var result = s.Compress(input);
        // Console.WriteLine(expected);
        // Console.WriteLine(new string('-', result.Length));
        // Console.WriteLine(result);
        // Assert.AreEqual(expected, result);
    }
}