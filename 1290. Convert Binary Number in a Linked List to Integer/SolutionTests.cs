using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        Solution s = new();
        var head = new ListNode(1, new ListNode(0, new ListNode(1, null)));
        int expected = 5;
        Assert.AreEqual(expected, s.GetDecimalValue(head));
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();
        var head = new ListNode();
        int expected = 0;
        Assert.AreEqual(expected, s.GetDecimalValue(head));
    }

    [Test]
    public void ExampleTest3()
    {
        Solution s = new();
        var head = new ListNode(1);
        int expected = 1;
        Assert.AreEqual(expected, s.GetDecimalValue(head));
    }

    [Test]
    public void ExampleTest4()
    {
        Solution s = new();
        // 1,0,0,1,0,0,1,1,1,0,0,0,0,0,0
        /*
        var head = new ListNode(1,
            new ListNode(0,
                new ListNode(0,
                    new ListNode(1,
                        new ListNode(0,
                            new ListNode(0,
                                new ListNode(1,
                                    new ListNode(1,
                                        new ListNode(1,
                                            new ListNode(0,
                                                new ListNode(0,
                                                    new ListNode(0,
                                                        new ListNode(0,
                                                            new ListNode(0, new ListNode()))))))))))))));
        */

        int[] binInts = {1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0};

        ListNode head = null;

        foreach (int x in binInts.Reverse())
        {
            var node = new ListNode(x, head);
            head = node;
        }

        int expected = 18880;
        Assert.AreEqual(expected, s.GetDecimalValue(head));
    }

    [Test]
    public void ExampleTest5()
    {
        Solution s = new();
        var head = new ListNode(0, new ListNode(0));
        int expected = 0;
        Assert.AreEqual(expected, s.GetDecimalValue(head));
    }
}