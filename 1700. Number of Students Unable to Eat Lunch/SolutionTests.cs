using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] students = {1, 1, 0, 0};
        int[] sandwiches = {0, 1, 0, 1};
        int expected = 0;
        Assert.AreEqual(expected, new Solution().CountStudents(students, sandwiches));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] students = {1, 1, 1, 0, 0, 1};
        int[] sandwiches = {1, 0, 0, 0, 1, 1};
        int expected = 3;
        Assert.AreEqual(expected, new Solution().CountStudents(students, sandwiches));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] students = {0, 0, 0, 1, 1, 1, 1, 0, 0, 0};
        int[] sandwiches = {1, 0, 1, 0, 0, 1, 1, 0, 0, 0};
        int expected = 0;
        Assert.AreEqual(expected, new Solution().CountStudents(students, sandwiches));
    }
}