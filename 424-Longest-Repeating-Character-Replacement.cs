public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left=0,max=0;
        int mostFreqLetterC=0;
        int[] charCounts=new int[26];

        for(int right=0;right<s.Length;right++){
            charCounts[s[right]-'A']++;
            mostFreqLetterC=Math.Max(mostFreqLetterC, charCounts[s[right]-'A']);
            int lettToChange=(right-left+1)- mostFreqLetterC;
            if(lettToChange>k){
                charCounts[s[left]-'A']--;
                left++;
            }
            max=Math.Max(max,(right-left+1));
        }
        return max;


    }
}