using System.Collections.Generic;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        // Your OrderedStream object will be instantiated and called as such:
        OrderedStream obj = new OrderedStream(5);
        IList<string> param_1 = obj.Insert(3, "ccccc");
        obj.Insert(1, "aaaaa");
        obj.Insert(2, "bbbbb");
        obj.Insert(5, "eeeee");
        obj.Insert(4, "ddddd");

        string[][] expected =
        {
            new[] {""},
            new[] {"aaaaa"},
            new[] {"bbbbb", "ccccc"},
            new[] {""},
            new[] {"ddddd", "eeeee"}
        };

        Assert.AreEqual(expected, param_1);
    }
}