using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        KthLargest kthLargest = new KthLargest(3, new[] {4, 5, 8, 2});
        int actual = kthLargest.Add(3);
        int expected = 4;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest2()
    {
        KthLargest kthLargest = new KthLargest(3, new[] {4, 5, 8, 2});
        kthLargest.Add(3);
        int actual = kthLargest.Add(5);
        int expected = 5;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest3()
    {
        KthLargest kthLargest = new KthLargest(3, new[] {4, 5, 8, 2});
        kthLargest.Add(3);
        kthLargest.Add(5);
        int actual = kthLargest.Add(10);
        int expected = 5;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest4()
    {
        KthLargest kthLargest = new KthLargest(3, new[] {4, 5, 8, 2});
        kthLargest.Add(3);
        kthLargest.Add(5);
        kthLargest.Add(10);
        int actual = kthLargest.Add(9);
        int expected = 8;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest5()
    {
        KthLargest kthLargest = new KthLargest(3, new[] {4, 5, 8, 2});
        kthLargest.Add(3);
        kthLargest.Add(5);
        kthLargest.Add(10);
        kthLargest.Add(9);
        int actual = kthLargest.Add(4);
        int expected = 8;
        Assert.Equal(expected, actual);
    }
}