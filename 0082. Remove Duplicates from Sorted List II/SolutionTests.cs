using NUnit.Framework;
using static ListUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {1, 2, 3, 3, 4, 4, 5};
        int[] expectedArr = {1, 2, 5};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().DeleteDuplicates(head);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] headArr = {1, 1, 1, 2, 3};
        int[] expectedArr = {2, 3};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().DeleteDuplicates(head);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }
}