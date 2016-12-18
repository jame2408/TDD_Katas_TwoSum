using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TwoSum
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valueIndex = new Dictionary<int, int>();

            if (nums.Length < 2)
            {
                return new int[] { 0, 0};
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (valueIndex.ContainsKey(complement))
                {
                    return new[] { valueIndex[complement], i };
                }

                if (!valueIndex.ContainsKey(nums[i]))
                {
                    valueIndex.Add(nums[i], i);
                }
            }

            return new int[] { 0, 0 };
        }
    }
}
