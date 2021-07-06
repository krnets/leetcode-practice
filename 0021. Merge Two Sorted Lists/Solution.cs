using static ListUtils;

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode l3 = new ListNode();
        var head = l3;

        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                l3.next = l1;
                l1 = l1.next;
            }
            else
            {
                l3.next = l2;
                l2 = l2.next;
            }

            l3 = l3.next;
        }

        l3.next = l1 ?? l2;

        return head.next;
    }
}