
MergeTwoLists(new ListNode(1, new ListNode(8, new ListNode(10))), new ListNode(2, new ListNode(5, new ListNode(9))));
Console.ReadLine();

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    var mergedList = new ListNode();
    var head = mergedList;
    while (list1 is not null && list2 is not null)
    {
        if (list1.val < list2.val)
        {
            head.next = list1;
            head=head.next;
            list1 = list1.next;
        }
        else
        {
            head.next = list2;
            head = head.next;
            list2 = list2.next;
        }
    }
    if (list1 is not null)
        head.next = list1;
    else if (list2 is not null)
        head.next = list2;
    return mergedList.next;
}

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
