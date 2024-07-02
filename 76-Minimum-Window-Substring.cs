public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(t)) return string.Empty;

        var countT = new Dictionary<char,int>();
        var window = new Dictionary<char,int>();

        foreach(char c in t){
            AddCharToDic(c,countT);
        }
        
        var have = 0;
        var need = countT.Count;
        var res= new[] {-1,-1};
        var resultLength= int.MaxValue;
        int left =0;

        for(int right =0 ; right<s.Length;right++ ){
            char c= s[right];
            AddCharToDic(c,window);

            if(countT.ContainsKey(c) && window[c]==countT[c]) have++;
     
        
            while(have==need){
                int windSize=right-left+1;
                if(windSize < resultLength){
                    res = new[] {left,right};
                    resultLength=windSize;
                }
                window[s[left]]--;
                if(countT.ContainsKey(s[left]) && window[s[left]]<countT[s[left]]) have--;

                left++;
            }  
         }
         return resultLength== int.MaxValue?string.Empty:s.Substring(res[0],res[1]-res[0]+1);
    }
    private void AddCharToDic(char c , Dictionary<char,int> dict){
        if(dict.ContainsKey(c)) dict[c]++;
        else dict.Add(c,1);
    }
}