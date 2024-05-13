public class Solution {
    public int RemoveElement(int[] nums, int val) {
         int pos=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=val){
                nums[pos]=nums[i];
                pos++;
            }
        }
        return pos;
    }
}