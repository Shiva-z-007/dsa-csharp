using System.Collections.Generic;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> h1 = new HashSet<int>(nums1);
        HashSet<int> h2 = new HashSet<int>(nums2);
        int[] res = h1.Intersect(h2).ToArray();
        return res;
    }
}