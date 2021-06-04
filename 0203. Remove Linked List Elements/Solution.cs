using System.Security.Cryptography;
using static ListUtils;

/*public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var sentinel = new ListNode(-1, head);
        var prev = sentinel;

        while (head != null)
        {
            if (head.val == val)
                prev.next = head.next;
            else prev = head;

            head = head.next;
        }

        return sentinel.next;
    }
}*/


/*public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var sentinel = new ListNode();
        sentinel.next = head;
        var ptrNode = sentinel;

        while (ptrNode?.next != null)
        {
            if (ptrNode.next.val == val)
                ptrNode.next = ptrNode.next.next;
            else ptrNode = ptrNode.next;
        }

        return sentinel.next;
    }
}*/


public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null) return null;

        head.next = RemoveElements(head.next, val);

        return head.val == val ? head.next : head;
    }
}


/*public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null) return null;

        var listNode = RemoveElements(head.next, val);

        if (head.val == val) 
            return listNode;

        head.next = listNode;

        return head;
    }
}*/