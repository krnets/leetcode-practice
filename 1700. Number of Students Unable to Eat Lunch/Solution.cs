/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var queue = new Queue<int>(students);
        var stack = new Stack<int>(sandwiches.Reverse());
        int counter = students.Length * 4;

        while (stack.Count != 0)
        {
            var student = queue.Dequeue();

            if (stack.Peek() == student)
                stack.Pop();
            else queue.Enqueue(student);

            counter--;

            if (counter == 0)
                break;
        }

        return queue.Count;
    }
}*/

public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int queueLength = sandwiches.Length;
        int[] countPrefs = new int[2];

        foreach (int student in students)
        {
            countPrefs[student]++;
        }

        for (int i = 0; i < sandwiches.Length && countPrefs[sandwiches[i]] > 0; i++)
        {
            int x = sandwiches[i];
            countPrefs[x]--;
            queueLength--;
        }

        return queueLength;
    }
}