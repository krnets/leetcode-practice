/* 7. Reverse Integer
Easy

Given a 32-bit signed integer, reverse digits of an integer.

Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows. */

/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
    let reversed = 0;
    let sign = x < 0;
    x = Math.abs(x);
    while (x) {
        reversed = reversed * 10 + (x % 10);
        x = Math.floor(x / 10);
    }
    return reversed > 0x7FFFFFFF ? 0 : sign ? -reversed : reversed;
};

q = reverse(123) // 321
q
q = reverse(-123) // -321
q
q = reverse(12) // 21
q
q = reverse(1534236469) // 0
q