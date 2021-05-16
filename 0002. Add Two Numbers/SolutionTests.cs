using System.Text;
using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    private static string ListNodeToString(ListNode node)
    {
        var sb = new StringBuilder();

        while (node != null)
        {
            sb.Append(node.val);
            node = node.next;
        }

        return sb.ToString();
    }

    [Test]
    public void ExampleTest1()
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        ListNode result = s.AddTwoNumbers(l1, l2);
        ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        string resultStr = ListNodeToString(result);
        string expectedStr = ListNodeToString(expected);

        Assert.AreEqual(expectedStr, resultStr);
    }


    [Test]
    public void ExampleTest2()
    {
        ListNode l1 = new ListNode(0);
        ListNode l2 = new ListNode(0);
        ListNode result = s.AddTwoNumbers(l1, l2);
        ListNode expected = new ListNode(0);
        string resultStr = ListNodeToString(result);
        string expectedStr = ListNodeToString(expected);

        Assert.AreEqual(expectedStr, resultStr);
    }

    [Test]
    public void ExampleTest3()
    {
        ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9,
            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));

        ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

        ListNode result = s.AddTwoNumbers(l1, l2);
        ListNode expected = new ListNode(8, new ListNode(9, new ListNode(9,
            new ListNode(9, new ListNode(0, new ListNode(0,
                new ListNode(0, new ListNode(1))))))));

        string resultStr = ListNodeToString(result);
        string expectedStr = ListNodeToString(expected);

        Assert.AreEqual(expectedStr, resultStr);
    }


    [Test]
    public void ExampleTest4()
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(9)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9))));
        ListNode result = s.AddTwoNumbers(l1, l2);
        ListNode expected = new ListNode(7, new ListNode(0,
            new ListNode(4, new ListNode(0, new ListNode(1)))));
        string resultStr = ListNodeToString(result);
        string expectedStr = ListNodeToString(expected);

        Assert.AreEqual(expectedStr, resultStr);
    }
}