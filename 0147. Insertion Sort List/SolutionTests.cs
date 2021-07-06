using NUnit.Framework;
using static ListUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {4, 2, 1, 3};
        int[] expectedArr = {1, 2, 3, 4};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().InsertionSortList(head);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] headArr = {-1, 5, 3, 4, 0};
        int[] expectedArr = {-1, 0, 3, 4, 5};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().InsertionSortList(head);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] headArr = { };
        int[] expectedArr = { };
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().InsertionSortList(head);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }
}