public class Solution {
    public int Trap(int[] height) {
        int left =0, right=height.Length-1;
        int leftmax=height[left], rightmax=height[right];
        int res=0;

        while(left<right){
            if(leftmax<rightmax){
                left++;
                leftmax=Math.Max(leftmax,height[left]);
                res+=leftmax-height[left];

            }
            else{
                right--;
                rightmax = Math.Max(rightmax, height[right]);
                res += rightmax - height[right];
            }
            }
            return res;
        }
    }
