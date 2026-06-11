//My Solution to the problem: https://leetcode.com/problems/isomorphic-strings/description/  //before optimization


using System.Collections.Generic;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, char> dic = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                if (dic[s[i]] != t[i]) return false;
            }
            else
            {
                if (dic.ContainsValue(t[i])) return false;
                dic[s[i]] = t[i];
            }
        }

        return true;
    }
}


// Optimization: we can use two dictionaries to avoid the O(n) time complexity of ContainsValue method, which will make the overall time complexity O(n) instead of O(n^2)

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, char> dicS = new Dictionary<char, char>();
        Dictionary<char, char> dicT = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];
            if (dicS.ContainsKey(c1))
            {
                if (dicS[c1] != c2) return false;
            }
            else
            {
                dicS[c1] = c2;
            }
            if (dicT.ContainsKey(c2))
            {
                if (dicT[c2] != c1) return false;
            }
            else
            {
                dicT[c2] = c1;
            }
        }
        return true;
    }
}