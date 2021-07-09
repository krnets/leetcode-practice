using static ListUtils;

/*public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;

        ListNode curr = head;

        while (curr != null && curr.next != null)
        {
            if (curr.val == curr.next.val)
                curr.next = curr.next.next;
            else
                curr = curr.next;
        }

        return head;
    }
}*/


public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head?.next == null) return head;

        head.next = DeleteDuplicates(head.next);

        return head.val == head.next.val ? head.next : head;
    }
}