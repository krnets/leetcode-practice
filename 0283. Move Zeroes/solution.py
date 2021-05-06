""" 283. Move Zeroes

Given an array nums, write a function to move all 0's to the end of it 
while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]

Note:

    You must do this in-place without making a copy of the array.
    Minimize the total number of operations. """


def moveZeroes(nums):
    """
    Do not return anything, modify nums in-place instead.
    """
    index = 0
    for i, x in enumerate(nums):
        if x:
            nums[index] = x
            index += 1
    for i in range(index, len(nums)):
        nums[i] = 0
    return nums


q = moveZeroes([0, 1, 0, 3, 12])
q
#      [1,3,12,0,0]
