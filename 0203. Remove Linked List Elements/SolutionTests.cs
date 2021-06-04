using NUnit.Framework;
using static ListUtils;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {1, 2, 6, 3, 4, 5, 6};
        const int val = 6;
        int[] expectedArr = {1, 2, 3, 4, 5};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().RemoveElements(head, val);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] headArr = { };
        const int val = 1;
        int[] expectedArr = { };
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().RemoveElements(head, val);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] headArr = {7, 7, 7, 7};
        const int val = 7;
        int[] expectedArr = { };
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().RemoveElements(head, val);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}