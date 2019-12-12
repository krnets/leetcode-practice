/* 392. Is Subsequence
Easy

Given a string s and a string t, check if s is subsequence of t.

You may assume that there is only lower case English letters in both s and t. 
t is potentially a very long (length ~= 500,000) string, and s is a short string (<=100).

A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) 
of the characters without disturbing the relative positions of the remaining characters. 
(ie, "ace" is a subsequence of "abcde" while "aec" is not).


/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isSubsequence = function (s, t) {
    if (!s) return true
    let s_index = 0
    let t_index = 0
    while (t_index < t.length) {
        if (t[t_index] == s[s_index])
            s_index++
        if (s_index == s.length)
            return true
        t_index++
    }
    return false
};

q = isSubsequence("abc", "ahbgdc") // true
q
q = isSubsequence("axc", "ahbgdc") // false
q
q = isSubsequence("", "ahbgdc") // true
q