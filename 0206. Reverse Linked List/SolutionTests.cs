using NUnit.Framework;
using static ListUtils;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {1, 2, 3, 4, 5};
        int[] expectedArr = {5, 4, 3, 2, 1};
        ListNode head = ConstructLinkedList(headArr);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().ReverseList(head);
        var headStr = TraverseLinkedList(head);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] headArr = {1, 2};
        int[] expectedArr = {2, 1};
        ListNode head = ConstructLinkedList(headArr);
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().ReverseList(head);
        var headStr = TraverseLinkedList(head);
        var expectedStr = TraverseLinkedList(expected);
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
        ListNode expected = ConstructLinkedList(expectedArr);
        ListNode actual = new Solution().ReverseList(head);
        var headStr = TraverseLinkedList(head);
        var expectedStr = TraverseLinkedList(expected);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}