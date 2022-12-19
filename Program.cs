using Advanced_DSA.Problems.Bit_Manipulation;
using Advanced_DSA.Problems.LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        ListNode A = new ListNode(1);
        var temp = A;
        for(int i=2; i<=6; i++)
        {
            temp.next = new ListNode(i);
            temp = temp.next;
        }


        var ans = PartialReverse.ReverseList(A, 3);
        Console.WriteLine(ans.val);
    }
}