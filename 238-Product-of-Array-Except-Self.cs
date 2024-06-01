public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] output = new int[n];
        output[0] = 1;
        for (int i = 1; i < n; i++)
        {
            output[i] = output[i - 1] * nums[i - 1]; // output[i] = left product of i element in nums   array 
        }
        int right = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= right; // output[i] = left product of i element in nums   array * right product of i element in nums   array
            right *= nums[i];
        }
        return output;
    }

}