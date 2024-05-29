public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
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

        List<int>[] bucket= new List<int>[nums.Length+1];
        foreach(int key in dict.Keys)
        {
            int freq = dict[key];
            if (bucket[freq]== null)
            {
                bucket[freq] = new List<int>();
            }
            bucket[freq].Add(key);

        }

        List<int> res = new List<int>();
        for (int i = bucket.Length-1; i >=0 && res.Count<k; i--)
        {
            if (bucket[i] != null)
                res.AddRange(bucket[i]);

        }
        return res.ToArray();

    }
}