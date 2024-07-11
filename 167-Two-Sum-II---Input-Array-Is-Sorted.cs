public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left=0;
        int right=numbers.Length-1;

        while(left<right){
            int current = numbers[left]+numbers[right];
            if(current<target)left++;
            else if(current>target)right--;
            else return new int[]{left+1,right+1};
            
        }
        return new int[0];
    }
}
