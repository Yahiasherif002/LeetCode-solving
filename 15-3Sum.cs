public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List <IList<int>> result = new List <IList<int>>();



        int Left;
        int Right;
        Array.Sort(nums);

        for(int i = 0; i<nums.Length;i++){
            if(i>0 && nums[i]==nums[i-1]) continue;
        

            int current = nums[i];
            Left=i+1;
             Right= nums.Length -1;

            while(Left<Right){
            int twoSum= nums[Left]+nums[Right];
            int ThreeSum= current + twoSum;

            if(ThreeSum>0) Right--;
             else if(ThreeSum<0) Left++;
             else{
                result.Add(new List<int>(){current,nums[Left],nums[Right]});
                Left++;
                Right--;
                while(nums[Left]==nums[Left-1] && Left<Right){
                    Left++;
                }
             }


            }

        
        }
        return result;
    }
}