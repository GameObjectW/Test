using System;
namespace Test
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class MergeTwoLists
    {
        public ListNode MergeTwoListsTest(ListNode l1, ListNode l2)
        {
            if (l1==null&l2==null)
            {
                return null;
            }
            if (l1==null&&l2!=null)
            {
                return l2;
            }
            if (l1 != null && l2 == null) {
                return l1;
            }

            ListNode final = new ListNode(999999);
            ListNode currentFinalNode = final;
            ListNode currentNodel1 = l1;
            ListNode currentNodel2 = l2;
            while (true)
            {
                if (currentNodel1.val<= currentNodel2.val)
                {
                    currentFinalNode.next = new ListNode(currentNodel1.val);
                    currentFinalNode = currentFinalNode.next;
                    currentNodel1 = currentNodel1.next;

                    if (currentNodel1==null)
                    {
                        currentFinalNode.next = currentNodel2;
                        return final.next;
                    }
                }
                else {
                    currentFinalNode.next = new ListNode(currentNodel2.val);
                    currentFinalNode = currentFinalNode.next;
                    currentNodel2 = currentNodel2.next;

                    if (currentNodel2 == null)
                    {
                        currentFinalNode.next = currentNodel1;
                        return final.next;
                    }
                }
            }
        }
    }
}
