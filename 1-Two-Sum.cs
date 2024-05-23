public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numMap = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int diff= target-nums[i]; // 9-2=7
            if(numMap.ContainsKey(diff)){
                return new int[] {numMap[diff],i};
            }
            numMap[nums[i]]=i;
        }
        return null;
}
}