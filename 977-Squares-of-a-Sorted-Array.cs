public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int p1 = 0;
        int p2 = nums.Length - 1;
        int[] result = new int[nums.Length];
        int index = nums.Length - 1;
        while (p1 <= p2)
        {
            if (nums[p1]* nums[p1] > nums[p2]* nums[p2]) // if the square of the number at p1 is greater than the square of the number at p2
            {
                result[index] = (nums[p1] * nums[p1]); // add the square of the number at p1 to the result array
                p1++; // move to the next number

            }
            else // if the square of the number at p2 is greater than the square of the number at p1
            {
                result[index] = (nums[p2] * nums[p2]); // add the square of the number at p2 to the result array
                p2--; // move to the next number
            }
            index--; // move to the next index in the result array
        }
        return result;
    }
}