using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int id;
    public int importance;
    public IList<int> subordinates;

    public Employee(int id, int importance, List<int> subordinates)
    {
        this.id = id;
        this.importance = importance;
        this.subordinates = subordinates;
    }
}

/*class Solution
{
    int total;

    public int GetImportance(IList<Employee> employees, int id)
    {
        Employee manager = employees.Single(e => e.id == id);

        total += manager.importance;

        foreach (var sub in manager.subordinates)
            GetImportance(employees, sub);

        return total;
    }
}*/

/*class Solution
{
    public int GetImportance(IList<Employee> employees, int id)
    {
        int total = 0;
        var idToEmployee = employees.ToDictionary(emp => emp.id);
        var queue = new Queue<int>();
        queue.Enqueue(id);

        while (queue.Count != 0)
        {
            var empId = queue.Dequeue();
            var emp = idToEmployee[empId];

            total += emp.importance;

            foreach (var empSubordinate in emp.subordinates)
                queue.Enqueue(empSubordinate);
        }

        return total;
    }
}*/

/*class Solution
{
    public int GetImportance(IList<Employee> employees, int id)
    {
        var idToEmployee = employees.ToDictionary(emp => emp.id);

        return DepthFirstSearch(id, idToEmployee);
    }

    private int DepthFirstSearch(int id, Dictionary<int, Employee> idToEmployee)
    {
        Employee emp = idToEmployee[id];
        int importance = emp.importance;

        foreach (var subordinate in emp.subordinates)
            importance += DepthFirstSearch(subordinate, idToEmployee);

        return importance;
    }
}*/

class Solution
{
    public int GetImportance(IList<Employee> employees, int id)
    {
        var idToEmployee = employees.ToDictionary(emp => emp.id);

        return DepthFirstSearch(id, idToEmployee);
    }

    private int DepthFirstSearch(int id, Dictionary<int, Employee> idToEmployee)
    {
        Employee emp = idToEmployee[id];

        return emp.importance + emp.subordinates.Sum(subordinate => DepthFirstSearch(subordinate, idToEmployee));
    }
}