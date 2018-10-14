using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        static List<int> twoSum (List<int> numList, int targetNum)
        {
            var hasAppeared = new Dictionary<int, int>();
            var returnList = new List<int>();
            int index = 0;
            foreach (int num in numList)
            {
                int matchTarget = targetNum - num;
                var matchTargetIndex = hasAppeared[matchTarget];
                if (matchTargetIndex != null)
                {
                    returnList.Add(matchTargetIndex, index);
                }
                index += 1;
            }
            return returnList;
        }
        // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        // Output: 7 -> 0 -> 8
        static LinkedListNode<int> addTwoNumbers (LinkedListNode list1, LinkedListNode list2)
        {
            var returnListNode = new LinkedListNode<int>();
            while (list1 != null && list2 != null)
            {
                returnListNode = addNodeValues(list1, list2);
            }
            return returnListNode;
        }
        static void appendNodeToList (LinkedListNode<int> list, int value)
        {
            if (list.Next != null)
            {
                var nextVal = list;
                list = new LinkedListNode<int>(value);
                list.Next = nextVal;
            }
            list = new LinkedListNode<int>(value);
        }
        static LinkedListNode<int> addNodeValues (LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            var list1Val = getLastNode(list1, true);
            var list2Val = getLastNode(list2, true);
            return new LinkedListNode<int>[list1.Value + list2.Value];
        }
        static LinkedListNode<int> getLastNode (LinkedListNode<int> list, bool deleteNode)
        {
            var currentNode = list;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            if (deleteNode)
            {
                currentNode.Next = null;
            }
            return currentNode.Next;
        }
    }
}
