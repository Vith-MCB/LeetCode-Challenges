public class Solution
{
    public String longestCommonPrefix(String[] strs)
    {
        if (strs.Length == 0) return "";
        String prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (String.IsNullOrEmpty(prefix)) return "";
            }
        return prefix;
    }

}

