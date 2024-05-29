# LeetCode problemSolving
## Array & Hashing
<details>
<summary>Array & Hashing</summary>

<details>
<summary>Top K Frequent Elements</summary>

#### Intuition
To solve the "Top K Frequent Elements" problem, we use a combination of a dictionary and bucket sort. The dictionary helps us count the frequency of each element in the input array. Once we have the frequencies, we use an array of lists (buckets) where each index represents a frequency. We place elements into the buckets based on their frequencies. Finally, we iterate through the bucket array from the highest frequency to the lowest, collecting the top k frequent elements.

This approach is efficient because it leverages the frequency information directly, making it possible to gather the most frequent elements without sorting the entire array of frequencies.

#### Pseudocode

1. **Count the Frequencies**:
   - Initialize an empty dictionary to store the frequency of each element.
   - Iterate through each element in the input array.
     - If the element is already in the dictionary, increment its count.
     - Otherwise, add the element to the dictionary with a count of 1.

2. **Bucket Sort**:
   - Initialize an array of lists (buckets) with a length of `nums.Length + 1`.
   - Iterate through the dictionary.
     - For each element, use its frequency as an index to place it in the corresponding bucket.

3. **Collect Top K Frequent Elements**:
   - Initialize an empty list to store the result.
   - Iterate through the bucket array from the end (highest frequency) to the start.
     - Add elements from non-empty buckets to the result list.
     - Stop when we have collected `k` elements.

4. **Return the Result**:
   - Convert the result list to an array and return it.

#### Time and Space Complexity
- **Time Complexity**: O(n), where n is the number of elements in the input array. This is because we iterate over the array to count frequencies and then iterate over the bucket array.
- **Space Complexity**: O(n), where n is the number of elements in the input array. We use additional space for the dictionary and the bucket array, both of which can grow proportionally to the number of elements.
</details>

</details>
