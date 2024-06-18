public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0,r=0,max=0;
        HashSet<int>chars=new HashSet<int>();
        while(r<s.Length){
            char curchar=s[r];
            if(chars.Contains(curchar)){
                chars.Remove(s[l]);
                l++;
            }
            else{
                chars.Add(curchar);
                max=Math.Max(max,r-l+1);
                r++;
            }
        }
        return max;
    }
}