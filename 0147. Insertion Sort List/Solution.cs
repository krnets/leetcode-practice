using static ListUtils;

public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        if (head == null) return head;

        var start = new ListNode();
        var prev = start;
        var curr = head;

        while (curr != null)
        {
            var tail = curr.next;

            while ((prev.next != null) && curr.val > prev.next.val)
            {
                prev = prev.next;
            }

            curr.next = prev.next;
            prev.next = curr;

            prev = start;
            curr = tail;
        }

        return start.next;
    }
}