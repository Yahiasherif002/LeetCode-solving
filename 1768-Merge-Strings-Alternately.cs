public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int p1= 0, p2 = 0;
        string result = "";
        while (p1 < word1.Length && p2 < word2.Length)
        {
            result += word1[p1++];
            result += word2[p2++];
        }
        while (p1 < word1.Length)
        {
            result += word1[p1++];
        }
        while (p2 < word2.Length)
        {
            result += word2[p2++];
        }
        return result;
    }
}