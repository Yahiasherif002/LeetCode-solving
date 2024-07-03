public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var output = new List<int>();
        LinkedList<int> queue = new();
        int left=0;
        int right=0;

        while(right<nums.Length){
            while(queue.Count>0 && nums[queue.Last.Value]<nums[right]){
                queue.RemoveLast();
            }
            queue.AddLast(right);

            if(left>queue.First.Value) queue.RemoveFirst();

            if(right+1>=k){
                output.Add(nums[queue.First.Value]);
                left++;
            }


            right++;
        }

        return output.ToArray();


        
    }
}