using NUnit.Framework;

public class SolutionTests
{
    private MyQueue myQueue = new();

    [Test]
    public void ExampleTest1()
    {
        myQueue.Push(1); // queue is: [1]
        myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
        var actual = myQueue.Peek(); // return 1
        var expected = 1;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        var actual = myQueue.Pop(); // return 1, queue is [2]
        var expected = 1;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        var actual = myQueue.Pop(); // return 2, queue is []
        var expected = 2;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest4()
    {
        myQueue.Push(3); // queue is: [3] 
        var actual = myQueue.Empty(); // return false
        var expected = false;
        Assert.AreEqual(expected, actual);
    }
}