using NUnit.Framework;
using static ListUtils;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3, 4, 5};
        var head = ConstructLinkedList(input);
        var actual = new Solution().MiddleNode(head);
        var expected = 3;
        Assert.AreEqual(expected, actual.val);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2, 3, 4, 5, 6};
        var head = ConstructLinkedList(input);
        var actual = new Solution().MiddleNode(head);
        var expected = 4;
        Assert.AreEqual(expected, actual.val);
    }
}