using NUnit.Framework;
using static ListUtils;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {1, 2, 3, 4, 5};
        int k = 2;
        int[] expectedArr = {4, 5, 1, 2, 3};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }


    [Test]
    public void ExampleTest2()
    {
        int[] headArr = {0, 1, 2};
        int k = 4;
        int[] expectedArr = {2, 0, 1};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] headArr = { };
        int k = 0;
        int[] expectedArr = { };
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest4()
    {
        int[] headArr = {1};
        int k = 0;
        int[] expectedArr = {1};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest5()
    {
        int[] headArr = {1, 2};
        int k = 0;
        int[] expectedArr = {1, 2};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest6()
    {
        int[] headArr = {1};
        int k = 1;
        int[] expectedArr = {1};
        ListNode head = ConstructLinkedList(headArr);
        var headStr = TraverseLinkedList(head);
        ListNode expected = ConstructLinkedList(expectedArr);
        var expectedStr = TraverseLinkedList(expected);
        ListNode actual = new Solution().RotateRight(head, k);
        var actualStr = TraverseLinkedList(actual);
        PrintResults(headStr, expectedStr, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}