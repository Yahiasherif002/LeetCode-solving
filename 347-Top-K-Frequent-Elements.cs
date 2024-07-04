public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] res = new int [k];
        var dict=new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;

            }
            else
            {
                dict.Add(num, 1);
            }
        }

       var heap= new PriorityQueue<int,int>();
       foreach(var key in dict.Keys){
        heap.Enqueue(key,dict[key]);
        if(heap.Count>k) heap.Dequeue();
       }

       int pos=k;
       while(heap.Count>0){
        res[--pos]=heap.Dequeue();
       }
       return res;

    }
}