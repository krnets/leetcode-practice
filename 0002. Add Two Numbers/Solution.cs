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


/*
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var clone1 = l1;
        var clone2 = l2;
        var sentintelFront = new ListNode();
        var sentintelBack = sentintelFront;

        int sum = 0;

        while (clone1 != null || clone2 != null)
        {
            sum /= 10;

            if (clone1 != null)
            {
                sum += clone1.val;
                clone1 = clone1.next;
            }

            if (clone2 != null)
            {
                sum += clone2.val;
                clone2 = clone2.next;
            }

            sentintelBack.next = new ListNode(sum % 10);
            sentintelBack = sentintelBack.next;
        }

        if (sum / 10 == 1)
            sentintelBack.next = new ListNode(1);

        return sentintelFront.next;
    }
}
*/


public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null, pointerNode = null, unevenTail;
        int sum, carry = 0;

        while (l1 != null && l2 != null)
        {
            sum = l1.val + l2.val + carry;

            if (sum >= 10)
            {
                sum -= 10;
                carry = 1;
            }
            else carry = 0;

            var sumNode = new ListNode(sum);

            if (head == null)
                head = sumNode;
            else pointerNode.next = sumNode;

            pointerNode = sumNode;

            l1 = l1.next;
            l2 = l2.next;
        }

        unevenTail = l1 ?? l2;

        while (unevenTail != null)
        {
            sum = unevenTail.val + carry;

            if (sum >= 10)
            {
                sum -= 10;
                carry = 1;
            }
            else carry = 0;

            var sumNode = new ListNode(sum);

            if (head == null)
                head = sumNode;
            else pointerNode.next = sumNode;

            pointerNode = sumNode;
            unevenTail = unevenTail.next;
        }

        if (carry > 0) 
            pointerNode.next = new ListNode(carry);

        return head;
    }
}