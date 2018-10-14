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
    }
}
