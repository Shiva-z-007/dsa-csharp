//My solution to the Problem : https://leetcode.com/problems/valid-anagram/description/

using System.Collections.Generic;

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