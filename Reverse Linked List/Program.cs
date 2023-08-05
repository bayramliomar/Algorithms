var node = new ListNode(10,new ListNode(8,new ListNode(7,new ListNode(11))));
ReverseList(node);
//10->8->7->11
ListNode ReverseList(ListNode head)
{
    ListNode prev = null, curr = head;

    while (curr != null)
    {
        var temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
    }
    return prev;
}
Console.ReadLine();
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

