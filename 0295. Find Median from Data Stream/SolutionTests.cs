using NUnit.Framework;

public class SolutionTests
{
    private readonly MedianFinder medianFinder = new();

    [Test]
    public void ExampleTest1()
    {
        medianFinder.AddNum(1); // arr = [1]
        medianFinder.AddNum(2); // arr = [1, 2]
        var actual = medianFinder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
        var expected = 1.5;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        medianFinder.AddNum(3); // arr[1, 2, 3]
        var actual = medianFinder.FindMedian();
        var expected = 2.0;
        Assert.AreEqual(expected, actual);
    }
}