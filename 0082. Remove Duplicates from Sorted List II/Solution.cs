using static ListUtils;

/*public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var sentinel = new ListNode(0, head);
        var curr = sentinel;

        while (curr != null)
        {
            if (curr.next?.next != null && curr.next.val == curr.next.next.val)
            {
                var temp = curr.next.next;

                while (temp?.next != null && temp.val == temp.next.val)
                {
                    temp = temp.next;
                }

                curr.next = temp.next;
            }
            else curr = curr.next;
        }

        return sentinel.next;
    }
}*/


public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;

        var sentinel = new ListNode(0, head);
        var predecessor = sentinel;

        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                    head = head.next;

                predecessor.next = head.next;
            }
            else predecessor = predecessor.next;

            head = head.next;
        }

        return sentinel.next;
    }
}