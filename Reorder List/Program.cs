var linkedList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
//old-> 1->2->3->4->5
//new-> 1->5->2->4->3
ReorderList(linkedList);



Console.ReadLine();
void ReorderList(ListNode head)
{
    if (head is null || head.next is null) 
        return;
    ListNode mid = FindMid(head);
    ListNode reversed = ReverseList(mid);
    Merge(head, reversed);

}
ListNode ReverseList(ListNode head)
{
    ListNode prev = null;
    var curr = head;

    while (curr is not null)
    {
        var temp = curr.next;
        curr.next = prev;
        prev=curr;
        curr = temp;
    }
    return prev;
}
ListNode FindMid(ListNode head)
{
    ListNode prev = null;
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        prev = slow;
        slow = slow.next;
        fast = fast.next.next;
    }
    prev.next = null;

    return slow;
}

void Merge(ListNode l1, ListNode l2)
{
    while (l2 != null)
    {
        ListNode next = l1.next;
        l1.next = l2;
        l1 = l2;
        l2 = next;
    }
}
//ListNode ReverseList2()
//{
//    var l1 = new ListNode(1);
//    var l2 = new ListNode(2);
//    l1.next = l2;

//    // we start at head
//    var head = l1;
//    ListNode newHead = null;

//    while(head is not null)
//    {
//        // store the node to the right to reuse later
//        var nextNode = head.next;
//        // set the current node's next to point backwards 
//        head.next = newHead;
//        // the previously right-side node is now processed
//        head = nextNode;


//    }

//    return null;
//}
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
