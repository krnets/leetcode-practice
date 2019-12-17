/* 15. 3Sum
Medium
Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
Find all unique triplets in the array which gives the sum of zero.
The solution set must not contain duplicate triplets.

Given array nums = [-1, 0, 1, 2, -1, -4],
A solution set is: [[-1, 0, 1],[-1, -1, 2]] */

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function (nums) {
    let result = [];
    nums.sort((a, b) => a - b);

    for (let i = 0; i < nums.length; ++i) {
        if (i == 0 || nums[i] > nums[i - 1]) {
            let start = i + 1;
            let end = nums.length - 1;
            while (start < end) {
                if (nums[i] + nums[start] + nums[end] == 0)
                    result.push([nums[i], nums[start], nums[end]])
                if (nums[i] + nums[start] + nums[end] < 0) {
                    let currentStart = start;
                    while (nums[start] == nums[currentStart] && start < end)
                        ++start;
                } else {
                    let currentEnd = end;
                    while (nums[end] == nums[currentEnd] && start < end)
                        --end;
                }
            }
        }
    }
    return result;
}; // Runtime: 156 ms, faster than 83.61% of JavaScript online submissions for 3Sum.  Memory Usage: 46.6 MB, less than 86.00% of JavaScript online submissions for 3Sum.


// const threeSum = (nums, target = 0) => {
//     const ret = [];
//     if (nums.length < 3) return ret;

//     nums = new Int32Array(nums);
//     nums.sort((a, b) => a - b);

//     for (let start = 0; start < nums.length; ++start) {
//         let mid = start + 1;
//         let end = nums.length - 1;

//         while (mid < end) {
//             const sum = nums[start] + nums[mid] + nums[end];

//             if (sum === target) {
//                 ret.push([nums[start], nums[mid], nums[end]]);
//                 while (nums[mid] === nums[mid + 1]) 
//                     ++mid;
//                 while (nums[end] === nums[end - 1]) 
//                     --end;
//                 ++mid;
//                 --end;
//             } else if (sum < target)
//                 ++mid;
//             else
//                 --end;
//         }
//         while (nums[start] === nums[start + 1]) 
//             ++start;
//     }

//     return ret;
// }; // sample 128 ms submission

q = threeSum([-1, 0, 1, 2, -1, -4]) // [[-1, 0, 1], [-1, -1, 2] ]
q