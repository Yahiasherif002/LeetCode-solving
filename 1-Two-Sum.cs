public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> numtoIndex= new Dictionary<int,int>();
       for(int i=0;i<nums.Length;i++){
        int complement= target-nums[i];
        if(numtoIndex.ContainsKey(complement)){
            return new int[]{numtoIndex[complement],i};
        }
        numtoIndex[nums[i]]=i; // If the complement does not exist, add the current number and its index to the dictionary
       }
       return null;
    }
}