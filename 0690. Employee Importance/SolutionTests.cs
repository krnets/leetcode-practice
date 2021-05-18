using System.Collections.Generic;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        Solution s = new();
        var employees = new List<Employee>()
        {
            new Employee(1, 5, new List<int> {2, 3}),
            new Employee(2, 3, new List<int>()),
            new Employee(3, 3, new List<int>())
        };
        int id = 1;
        int expected = 11;
        Assert.AreEqual(expected, s.GetImportance(employees, id));
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();
        var employees = new List<Employee>()
        {
            new Employee(1, 5, new List<int> {2, 3}),
            new Employee(2, 3, new List<int> {4}),
            new Employee(3, 4, new List<int>()),
            new Employee(4, 1, new List<int>())
        };
        int id = 1;
        int expected = 13;
        Assert.AreEqual(expected, s.GetImportance(employees, id));
    }

    [Test]
    public void ExampleTest3()
    {
        Solution s = new();
        var employees = new List<Employee>()
        {
            new Employee(1, 2, new List<int> {2}),
            new Employee(2, 3, new List<int>()),
        };
        int id = 2;
        int expected = 3;
        Assert.AreEqual(expected, s.GetImportance(employees, id));
    }
}