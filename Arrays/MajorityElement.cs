using System.Collections.Generic;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int feq = 0;
        int cnt = 0;
        foreach (int num in nums)
        {
            if (cnt == 0)
            {
                feq = num;
            }
            cnt += (num == feq) ? 1 : -1;
        }
        return feq;
    }
}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
            {
                dic[c] += 1;
            }
            else
            {
                dic[c] = 1;
            }
        }
        foreach (char c in t)
        {
            if (dic.ContainsKey(c))
            {
                dic[c] -= 1;
            }
            else
            {
                return false;
            }
        }
        foreach (var (key, val) in dic)
        {
            if (val != 0) return false;
        }
        return true;
    }
}