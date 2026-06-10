using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<IList<int>> res = new List<IList<int>>();
        HashSet<int> h1 = new HashSet<int>(nums1);
        HashSet<int> h2 = new HashSet<int>(nums2);
        res.Add(h1.Except(h2).ToList());
        res.Add(h2.Except(h1).ToList());
        return res;

    }
}