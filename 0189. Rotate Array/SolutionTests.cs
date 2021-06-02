using System;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7};
        int k = 3;
        int[] expected = {5, 6, 7, 1, 2, 3, 4};
        Console.WriteLine($"before:   {string.Join(" ", nums)}");
        new Solution().Rotate(nums, k);
        Console.WriteLine($"expected: {string.Join(" ", expected)}");
        Console.WriteLine($"after:    {string.Join(" ", nums)}");

        Assert.AreEqual(expected, nums);
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {-1, -100, 3, 99};
        int k = 2;
        int[] expected = {3, 99, -1, -100};
        Console.WriteLine($"before:   {string.Join(" ", nums)}");
        new Solution().Rotate(nums, k);
        Console.WriteLine($"expected: {string.Join(" ", expected)}");
        Console.WriteLine($"after:    {string.Join(" ", nums)}");

        Assert.AreEqual(expected, nums);
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int k = 3;
        int[] expected = {8, 9, 10, 1, 2, 3, 4, 5, 6, 7};
        Console.WriteLine($"before:   {string.Join(" ", nums)}");
        new Solution().Rotate(nums, k);
        Console.WriteLine($"expected: {string.Join(" ", expected)}");
        Console.WriteLine($"after:    {string.Join(" ", nums)}");

        Assert.AreEqual(expected, nums);
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {-1};
        int k = 2;
        int[] expected = {-1};
        Console.WriteLine($"before:   {string.Join(" ", nums)}");
        new Solution().Rotate(nums, k);
        Console.WriteLine($"expected: {string.Join(" ", expected)}");
        Console.WriteLine($"after:    {string.Join(" ", nums)}");

        Assert.AreEqual(expected, nums);
    }
}