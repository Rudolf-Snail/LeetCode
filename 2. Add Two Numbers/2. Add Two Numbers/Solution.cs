namespace _2._Add_Two_Numbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int addition = 0; 
            int currentSum = l1.val + l2.val + addition; // You are given two NON-EMPTY linked-lists
            addition = currentSum / 10;

            ListNode currentNumberResult = new(currentSum % 10); 
            ListNode result = currentNumberResult;

            int l1Value, l2Value;

            for (ListNode currentL1Node = l1.next, currentL2Node = l2.next; currentL1Node != null || currentL2Node != null;)
            {
                currentNumberResult.next = new();
                currentNumberResult = currentNumberResult.next;

                if (currentL1Node != null && currentL2Node != null)
                {
                    l1Value = currentL1Node.val;
                    l2Value = currentL2Node.val;
                
                    currentSum = l1Value + l2Value + addition;
                    addition = currentSum / 10;
                    currentNumberResult.val = currentSum % 10;

                    currentL1Node = currentL1Node.next;
                    currentL2Node = currentL2Node.next;
                }
                else if (currentL1Node == null)
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    l2Value = currentL2Node.val; // Once again, the compiler is wrong, or at least should be.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    
                    currentSum = l2Value + addition;
                    addition = currentSum / 10;
                    currentNumberResult.val = currentSum % 10;

                    currentL2Node = currentL2Node.next;
                }
                else
                {
                    l1Value = currentL1Node.val;
                    
                    currentSum = l1Value + addition;
                    addition = currentSum / 10;
                    currentNumberResult.val = currentSum % 10;

                    currentL1Node = currentL1Node.next;
                }
            }

            while (addition > 0)
            {
                currentNumberResult.next = new();
                currentNumberResult = currentNumberResult.next;
                
                currentSum = addition;
                addition = currentSum / 10;
                currentNumberResult.val = currentSum % 10;
            }

            return result;
        }
    }
}
