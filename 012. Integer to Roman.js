/* 12. Integer to Roman
Medium

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, two is written as II in Roman numeral, just two one's added together. 
Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

Given an integer, convert it to a roman numeral. Input is guaranteed to be within the range from 1 to 3999.

Example 1:

Input: 3
Output: "III"

Example 2:

Input: 4
Output: "IV"

Example 3:

Input: 9
Output: "IX"

Example 4:

Input: 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.

Example 5:

Input: 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Accepted
288,236
Submissions
545,096 */

/**
 * @param {number} num
 * @return {string}
 */
var intToRoman = function (num) {
    let thousands = ['', 'M', 'MM', 'MMM'];
    let hundreds = ['', 'C', 'CC', 'CCC', 'CD', 'D', 'DC', 'DCC', 'DCCC', 'CM'];
    let tens = ['', 'X', 'XX', 'XXX', 'XL', 'L', 'LX', 'LXX', 'LXXX', 'XC'];
    let units = ['', 'I', 'II', 'III', 'IV', 'V', 'VI', 'VII', 'VIII', 'IX'];

    return thousands[Math.floor(num / 1000)] +
        hundreds[Math.floor((num % 1000) / 100)] +
        tens[Math.floor((num % 100) / 10)] +
        units[num % 10]
};
// Runtime: 140 ms, faster than 70.52% of JavaScript online submissions for Integer to Roman.
// Memory Usage: 39.8 MB, less than 80.00% of JavaScript online submissions for Integer to Roman.

// var intToRoman = function (num) {
//     let roman = ['M', 'CM', 'D', 'CD', 'C', 'XC', 'L', 'XL', 'X', 'IX', 'V', 'IV', 'I'];
//     let numbers = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
//     let str = '';
//     let i = 0;
//     while (num > 0) {
//         if (num - numbers[i] >= 0) {
//             str += roman[i];
//             num -= numbers[i];
//         } else {
//             i++
//         }
//     }
//     return str;
// }
// Runtime: 152 ms, faster than 37.11% of JavaScript online submissions for Integer to Roman.
// Memory Usage: 40 MB, less than 60.00% of JavaScript online submissions for Integer to Roman.

// var intToRoman = function (num) {
//     const Map = {
//         'M': 1000,
//         'CM': 900,
//         'D': 500,
//         'CD': 400,
//         'C': 100,
//         'XC': 90,
//         'L': 50,
//         'XL': 40,
//         'X': 10,
//         'IX': 9,
//         'V': 5,
//         'IV': 4,
//         'I': 1,
//     }
//     let result = ''
//     for (val in Map) {
//         result += val.repeat(Math.floor(num / Map[val]))
//         num %= Map[val]
//     }
//     return result
// };
// sample 108 ms submission

// function intToRoman(num) {
//     const map = { M: 1000, CM: 900, D: 500, CD: 400, C: 100, XC: 90, L: 50, XL: 40, X: 10, IX: 9, V: 5, IV: 4, I: 1 };
//     let result = '';
//     Object.entries(map).forEach(([letter, n]) => {
//         result += letter.repeat(Math.floor(num / n));
//         num %= n;
//     });
//     return result;
// }


// function intToRoman(num) {
//     const map = { M: 1000, CM: 900, D: 500, CD: 400, C: 100, XC: 90, L: 50, XL: 40, X: 10, IX: 9, V: 5, IV: 4, I: 1 };
//     return Object.entries(map).reduce((result, [letter, n]) => {
//         result += letter.repeat(Math.floor(num / n));
//         num %= n;
//         return result;
//     }, '');
// }


q = intToRoman(1) // 'I'
q
q = intToRoman(4) // 'IV'
q
q = intToRoman(49) // 'XLIX'
q
q = intToRoman(1985) // 'MCMLXXXV'
q
q = intToRoman(2020) // 'MMXX'
q
q = intToRoman(2028) // 'MMXXVIII'
q
q = intToRoman(2029) // 'MMXXIX'
q
q = intToRoman(1994) // 'MCMXCIV'
q
q = intToRoman(3999) // 'MMMCMXCIX'
q
q = intToRoman(1) === 'I'
q
q = intToRoman(4) === 'IV'
q
q = intToRoman(49) === 'XLIX'
q
q = intToRoman(1985) === 'MCMLXXXV'
q
q = intToRoman(2020) === 'MMXX'
q
q = intToRoman(2028) === 'MMXXVIII'
q
q = intToRoman(2029) === 'MMXXIX'
q
q = intToRoman(1994) === 'MCMXCIV'
q
q = intToRoman(3999) === 'MMMCMXCIX'
q