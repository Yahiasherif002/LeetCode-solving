class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        k = 0
        for num in nums:
            if k<2 or nums[k-2]<num:
                nums[k]=num
                k+=1
        return k            
        