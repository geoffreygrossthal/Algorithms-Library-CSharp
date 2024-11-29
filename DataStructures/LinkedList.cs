namespace DataStructures.LinkedList
{
    // Class and methods for cycle detection using Tortoise and Hare algorithm.
    public class TortoiseAndHare
    {
        // Time Complexity: O(n), where n is the number of nodes in the linked list.
        // The slow pointer moves one step at a time, and the fast pointer moves two steps at a time.
        // In the worst case, the slow pointer will traverse the entire list once, making the time complexity O(n).
        // Space Complexity: O(1), since the algorithm only uses two pointers (slow and fast) 
        // and does not require any additional data structures that grow with the size of the list.
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }
    }

    // ListNode class for linked list node structure.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}