using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 2, 2, 3};
        int val = 3;
        int expected = 2; // [2,2]

        Assert.AreEqual(expected, s.RemoveElement(nums, val));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {0, 1, 2, 2, 3, 0, 4, 2};
        int val = 2;
        int expected = 5; // [0,1,4,0,3]

        Assert.AreEqual(expected, s.RemoveElement(nums, val));
    }
}