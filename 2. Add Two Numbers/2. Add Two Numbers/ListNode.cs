namespace _2._Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            string result = "";
            ListNode currentNode = this;

            while (currentNode != null)
            {
                result += $"{currentNode.val},";

                currentNode = currentNode.next;
            }

            return result;
        }
    }
}
