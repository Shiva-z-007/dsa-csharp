//my solution for the problem: https://leetcode.com/problems/ransom-note/description/

using System.Collections.Generic;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (dic.ContainsKey(magazine[i]))
            {
                dic[magazine[i]] += 1;
            }
            else
            {
                dic[magazine[i]] = 1;
            }
        }
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (dic.ContainsKey(ransomNote[i]) && dic[ransomNote[i]] > 0)
            {
                dic[ransomNote[i]] -= 1;
            }
            else
            {
                return false;
            }
        }
        return true;

    }
}