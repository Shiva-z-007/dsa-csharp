/*
Problem:
Contains Duplicate

Difficulty:
Easy

Concepts:
Array
HashSet
Hashing

Approach:
Traverse the array and store elements in a HashSet.
If an element already exists in the HashSet,
a duplicate is found.

Time Complexity:
O(n)

Space Complexity:
O(n)

LeetCode:
217. Contains Duplicate
*/
using System.Collections;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Hashtable m = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            if (m.ContainsKey(nums[i])) return true;
            else
            {
                m[nums[i]] = 1;
            }
        }
        return false;
    }
}