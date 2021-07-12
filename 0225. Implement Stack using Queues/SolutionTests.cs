using NUnit.Framework;

public class SolutionTests
{
    private MyStack myStack = new();

    [Test]
    public void ExampleTest1()
    {
        myStack.Push(1);
        myStack.Push(2);
        var actual = myStack.Top(); // return 2
        var expected = 2;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        var actual = myStack.Pop(); // return 2
        var expected = 2;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        var actual = myStack.Empty(); // return False
        var expected = false;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest4()
    {
        myStack.Push(1);
        myStack.Push(2);
        myStack.Pop(); // return 2
        var actual = myStack.Top(); // return 1
        var expected = 1;
        Assert.AreEqual(expected, actual);
    }
}