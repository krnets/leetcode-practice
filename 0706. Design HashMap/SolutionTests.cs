using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        int actual = myHashMap.Get(1); // return 1, The map is now [[1,1], [2,2]]
        Assert.Equal(1, actual);
    }

    [Fact]
    public void ExampleTest2()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        int actual = myHashMap.Get(3); // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
        Assert.Equal(-1, actual);
    }

    [Fact]
    public void ExampleTest3()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        int actual = myHashMap.Get(2); // return 1, The map is now [[1,1], [2,1]]
        Assert.Equal(1, actual);
    }

    [Fact]
    public void ExampleTest4()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
        int actual = myHashMap.Get(2); // return -1 (i.e., not found), The map is now [[1,1]]
        Assert.Equal(-1, actual);
    }
}