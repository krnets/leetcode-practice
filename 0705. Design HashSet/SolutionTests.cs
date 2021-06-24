using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1); // set = [1]
        myHashSet.Add(2); // set = [1, 2]
        var actual = myHashSet.Contains(1); // return True
        Assert.True(actual);
    }

    [Fact]
    public void ExampleTest2()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1); // set = [1]
        myHashSet.Add(2); // set = [1, 2]
        myHashSet.Add(2); // set = [1, 2]
        var actual = myHashSet.Contains(2); // return True
        Assert.True(actual);
    }

    [Fact]
    public void ExampleTest3()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1); // set = [1]
        myHashSet.Add(2); // set = [1, 2]
        myHashSet.Add(2); // set = [1, 2]
        myHashSet.Remove(2); // set = [1]
        var actual = myHashSet.Contains(2); // return False, (already removed)
        Assert.False(actual);
    }

    [Fact]
    public void ExampleTest4()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1); // set = [1]
        myHashSet.Add(2); // set = [1, 2]
        var actual = myHashSet.Contains(3); // return False, (never added)
        Assert.False(actual);
    }
}