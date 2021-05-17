using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] startTime = {1, 2, 3};
        int[] endTime = {3, 2, 7};
        int queryTime = 4;
        int expected = 1;
        Assert.AreEqual(expected, s.BusyStudent(startTime, endTime, queryTime));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] startTime = {4};
        int[] endTime = {4};
        int queryTime = 4;
        int expected = 1;
        Assert.AreEqual(expected, s.BusyStudent(startTime, endTime, queryTime));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] startTime = {4};
        int[] endTime = {4};
        int queryTime = 5;
        int expected = 0;
        Assert.AreEqual(expected, s.BusyStudent(startTime, endTime, queryTime));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] startTime = {1, 1, 1, 1};
        int[] endTime = {1, 3, 2, 4};
        int queryTime = 7;
        int expected = 0;
        Assert.AreEqual(expected, s.BusyStudent(startTime, endTime, queryTime));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] startTime = {9, 8, 7, 6, 5, 4, 3, 2, 1};
        int[] endTime = {10, 10, 10, 10, 10, 10, 10, 10, 10};
        int queryTime = 5;
        int expected = 5;
        Assert.AreEqual(expected, s.BusyStudent(startTime, endTime, queryTime));
    }
}