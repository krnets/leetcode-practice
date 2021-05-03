/* 1. Two Sum
Easy

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1]. */

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

var twoSum = function (nums, target) {
    let map = new Map();
    for (let i = 0; i < nums.length; i++) {
        let delta = target - nums[i];
        if (map.has(delta)) {
            return [map.get(delta), i]
        }
        map.set(nums[i], i);
    }
    return [-1, -1];
};

q = twoSum([2, 7, 11, 15], 9) // [0, 1]
q
q = twoSum([2, 7, 11, 15], 13) // [0, 2]
q
q = twoSum([2, 7, 11, 15], 22) // [1, 3]
q
q = twoSum([2, 7, 11, 15], 23) // [1, 3]
q