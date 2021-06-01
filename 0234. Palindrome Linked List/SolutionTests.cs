using NUnit.Framework;
using static ListUtils;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] headArr = {1, 2, 2, 1};
        var head = ConstructLinkedList(headArr);
        var actual = new Solution().IsPalindrome(head);

        Assert.IsTrue(actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] headArr = {1, 2};
        var head = ConstructLinkedList(headArr);
        var actual = new Solution().IsPalindrome(head);

        Assert.IsFalse(actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] headArr = {1, 2, 3, 4, 5, 4, 3, 2, 1};
        var head = ConstructLinkedList(headArr);
        var actual = new Solution().IsPalindrome(head);

        Assert.IsTrue(actual);
    }
}