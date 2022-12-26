namespace Advanced_DSA.Problems.LinkedList;

public static class PartialReverse
{
    public static ListNode DeleteDuplicates(ListNode A)
    {
        ListNode prev = null, curr = A;
        while (curr != null)
        {
            if (prev != null && curr.val == prev.val)
            {
                prev.next = null;
                curr = curr.next;
            }
            else
            {
                if(prev == null) prev = curr;
                else
                {
                    prev.next = curr;
                    prev = curr;
                }
                curr = curr.next;
            }
        }

        return A;
    }
    public static ListNode ReverseBetween(ListNode A, int B, int C)
    {
        ListNode before = null, prev = null, curr = A;
        for (int i = 1; i <= C; i++)
        {
            if (i < B)
            {
                before = curr;
                curr = curr.next;
                continue;
            }
            ListNode nxt = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nxt;
        }

        ListNode temp;
        if (B != 1)
        {
            before.next = prev;
            temp = before;
        }
        else
        {
            A = prev;
            temp = A;
        }

        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = curr;
        return A;
    }
    public static ListNode ReverseList(ListNode A, int B)
    {
        ListNode join = null, curr = A;
        
        while (curr != null)
        {
            int cnt = 1;
            ListNode prev = null;
            while (cnt <= B && curr != null)
            {
                ListNode nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
                cnt++;
            }
            if (join == null) join = prev;
            else
            {
                ListNode temp = join;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = prev;
            }
        }
        return join;
    }
}

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x) { this.val = x; this.next = null; }
}

/*
        ListNode A = new ListNode(1);
        var temp = A;
        for(int i=2; i<=6; i++)
        {
            temp.next = new ListNode(i);
            temp = temp.next;
        }
        var ans = PartialReverse.ReverseList(A, 3);
        Console.WriteLine(ans.val);
 */