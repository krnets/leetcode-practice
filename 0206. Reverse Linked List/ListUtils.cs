using System;
using System.Text;

public class ListUtils
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode ConstructLinkedList(int[] array)
    {
        if (array == null || array.Length == 0)
            return null;

        var prev = new ListNode(-1);
        var head = new ListNode(array[0]);
        prev.next = head;

        for (int i = 1; i < array.Length; i++)
        {
            head.next = new ListNode(array[i]);
            head = head.next;
        }

        return prev.next;
    }

    public static string TraverseLinkedList(ListNode head)
    {
        var sb = new StringBuilder();
        var temp = head;

        while (temp != null)
        {
            sb.Append($"{temp.val} -> ");
            temp = temp.next;
        }

        sb.Append("null");

        return sb.ToString();
    }

    public static void PrintResults(string headStr, string expectedStr, string actualStr)
    {
        Console.WriteLine($"original: {headStr}");
        Console.WriteLine($"expected: {expectedStr}");
        Console.WriteLine($"actual: {actualStr}");
    }
}