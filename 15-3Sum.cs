public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        int l, r;
        Array.Sort(nums);

        for(int i=0;i<nums.Length;i++){
            if(i > 0 && nums[i] == nums[i-1]){
                continue;
            }

            int c=nums[i];
            
            l=i+1;
            r=nums.Length-1;
            

            while(l<r){
            int sum=nums[l]+nums[r];
            int threeSum=c+sum;
                if(threeSum>0){
                    r--;
                }
                else if (threeSum<0){
                    l++;
                }
                else{
                    res.Add(new List<int>{nums[i],nums[l],nums[r]});
                    l++;
                    while(nums[l]==nums[l-1] && l<r){
                        l++;
                    }
                }

            }
        }
        return res;
    }
}