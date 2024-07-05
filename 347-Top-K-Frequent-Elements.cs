public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
       var dict = new Dictionary<int,int>();

       foreach(var num in nums){
        if(dict.ContainsKey(num)) dict[num]++;
        else dict[num]=1;
       }

       var bucket = new List<int>[nums.Length+1];
       foreach(var key in dict.Keys){
        int freq= dict[key];
        if(bucket[freq] == null) bucket[freq]=new List<int>();
         bucket[freq].Add(key);
       }

       var result = new List<int>();
       for(int i = bucket.Length-1;i>=0 && result.Count<k ; i--){
        if (bucket[i] != null) result.AddRange(bucket[i]);
       }
        return result.Take(k).ToArray();
    }
}