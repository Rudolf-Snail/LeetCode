namespace _2._Add_Two_Numbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int addition = 0, currentSum = 0;
            int l1Value = l1.val;
            int l2Value = l2.val;
            ListNode currentNodeOfResult = new();

            CalculateCurrentNumber(ref addition, ref currentSum, currentNodeOfResult, ref l1Value, ref l2Value);

            ListNode result = currentNodeOfResult;

            for (ListNode? currentL1Node = l1.next, currentL2Node = l2.next; currentL1Node != null || currentL2Node != null || addition > 0;)
            {
                currentNodeOfResult = CreateAndMoveToNextNode(currentNodeOfResult);

                CurrentNodesNumbers(out l1Value, out l2Value, currentL1Node, currentL2Node);
                currentSum = CalculateCurrentNumber(ref addition, ref currentSum, currentNodeOfResult, ref l1Value, ref l2Value);

                NextNodes(ref currentL1Node, ref currentL2Node);
            }

            return result;
        }

        private static void NextNodes(ref ListNode? currentL1Node, ref ListNode? currentL2Node)
        {
            currentL1Node = NextNode(currentL1Node);
            currentL2Node = NextNode(currentL2Node);
        }

        private static ListNode? NextNode(ListNode? currentNode)
        {
            if (currentNode == null)
                return currentNode;

            currentNode = currentNode.next;
            return currentNode;
        }

        private static void CurrentNodesNumbers(out int l1Value, out int l2Value, ListNode? currentL1Node, ListNode? currentL2Node)
        {
            l1Value = CurrentNumber(currentL1Node);
            l2Value = CurrentNumber(currentL2Node);
        }

        private static int CurrentNumber(ListNode? currentNode) => (currentNode != null) ? currentNode.val : 0;

        private static int CalculateCurrentNumber(ref int addition, ref int currentSum, ListNode currentNodeOfResult, ref int l1Value, ref int l2Value)
        {
            currentSum = l1Value + l2Value + addition;
            addition = currentSum / 10;
            currentNodeOfResult.val = currentSum % 10;

            return currentSum;
        }

        private static ListNode CreateAndMoveToNextNode(ListNode currentNumberResult)
        {
            currentNumberResult.next = new();
            currentNumberResult = currentNumberResult.next;

            return currentNumberResult;
        }
    }
}
