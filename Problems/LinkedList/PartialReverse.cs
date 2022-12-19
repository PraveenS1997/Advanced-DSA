namespace Advanced_DSA.Problems.LinkedList;

public static class PartialReverse
{
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