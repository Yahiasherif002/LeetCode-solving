public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s==t) return true;

        Dictionary <char,int> sCount= new Dictionary <char,int>();
        Dictionary <char,int> tCount= new Dictionary <char,int>();

        for(int i=0;i<s.Length;i++){
            sCount[s[i]]=1+(sCount.ContainsKey(s[i]) ? sCount[s[i]] :0);
            tCount[t[i]]=1+(tCount.ContainsKey(t[i]) ? tCount[t[i]] :0);
        }

        foreach (char c in sCount.Keys) {
            if (!tCount.ContainsKey(c) || sCount[c] != tCount[c]) {
                return false;
            }
        }

        return true;


 
    }
}