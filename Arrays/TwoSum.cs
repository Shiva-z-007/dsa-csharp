/*
Problem:
Two Sum

Difficulty:
Easy

Concepts:
Array
Dictionary
HashMap

Time Complexity:
O(n)

Space Complexity:
O(n)
*/
using System;
using System.Collections;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable m = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            int rem = target - nums[i];
            if (m.ContainsKey(rem))
            {
                object value = m[rem];
                int val = Convert.ToInt32(value);
                return new int[] { val, i };
            }

            m[nums[i]] = i;

        }
        return null;
    }
}