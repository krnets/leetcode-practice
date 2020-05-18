# 415. Add Strings

""" Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.

Note:

    The length of both num1 and num2 is < 5100.
    Both num1 and num2 contains only digits 0-9.
    Both num1 and num2 does not contain any leading zero.
    You must not use any built-in BigInteger library or convert the inputs to integer directly. """


class Solution:
    def addStrings(self, num1: str, num2: str) -> str:
        res = []
        i = len(num1)-1
        j = len(num2)-1
        carry = 0
        while i >= 0 or j >= 0:
            qsum = carry
            if i >= 0:
                qsum += int(num1[i])
                i -= 1
            if j >= 0:
                qsum += int(num2[j])
                j -= 1
            res.append(int(qsum) % 10)
            carry = qsum // 10
        if carry:
            res.append(carry)
        return ''.join(map(str, res[::-1]))

# class Solution:
#     def addStrings(self, num1: str, num2: str) -> str:
#         res = []
#         i = len(num1)-1
#         j = len(num2)-1
#         carry = 0
#         while i >= 0 or j >= 0:
#             tmp = carry
#             if i >= 0:
#                 tmp += int(num1[i])
#                 i -= 1
#             if j >= 0:
#                 tmp += int(num2[j])
#                 j -= 1
#             res.append(int(tmp) % 10)
#             carry = tmp // 10
#         if carry:
#             res.append(carry)
#         return ''.join(map(str, res[::-1]))

# class Solution:
#     def addStrings(self, num1: str, num2: str) -> str:
#         res = []
#         i = len(num1)-1
#         j = len(num2)-1
#         carry = 0
#         while i >= 0 or j >= 0:
#             a = 0 if i < 0 else int(num1[i])
#             b = 0 if j < 0 else int(num2[j])
#             tmp = a + b + carry
#             res.append(str(tmp % 10))
#             carry = tmp // 10
#             i -= 1
#             j -= 1
#         if carry:
#             res.append(carry)
#         return ''.join(map(str, res[::-1]))


s = Solution()
s
q = s.addStrings('856', '856')
q
