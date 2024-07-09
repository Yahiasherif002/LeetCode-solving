public class Solution {
    public int LongestConsecutive(int[] nums) {
       var numSet= new HashSet<int>(nums);
       int longest=0;
       foreach(var num in nums){
        if(!numSet.Contains(num-1)){
             int length=0;
             while(numSet.Contains(num+length++)){
                longest=Math.Max(length,longest);
             }
        }
       }
       return longest;
    }
}