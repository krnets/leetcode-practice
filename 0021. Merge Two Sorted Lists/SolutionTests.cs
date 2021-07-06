using NUnit.Framework;
using static ListUtils;

[Parallelizable(ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] arr1 = {1, 2, 4};
        int[] arr2 = {1, 3, 4};
        int[] expectedArr = {1, 1, 2, 3, 4, 4};
        ListNode head1 = ConstructLinkedList(arr1);
        ListNode head2 = ConstructLinkedList(arr2);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().MergeTwoLists(head1, head2);
        var headStr1 = TraverseLinkedList(head1);
        var headStr2 = TraverseLinkedList(head2);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr1, headStr2, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] arr1 = {};
        int[] arr2 = {};
        int[] expectedArr = {};
        ListNode head1 = ConstructLinkedList(arr1);
        ListNode head2 = ConstructLinkedList(arr2);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().MergeTwoLists(head1, head2);
        var headStr1 = TraverseLinkedList(head1);
        var headStr2 = TraverseLinkedList(head2);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr1, headStr2, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] arr1 = {};
        int[] arr2 = {0};
        int[] expectedArr = {0};
        ListNode head1 = ConstructLinkedList(arr1);
        ListNode head2 = ConstructLinkedList(arr2);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().MergeTwoLists(head1, head2);
        var headStr1 = TraverseLinkedList(head1);
        var headStr2 = TraverseLinkedList(head2);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr1, headStr2, expectedStr, actualStr);
        Assert.AreEqual(expectedStr, actualStr);
    }
}