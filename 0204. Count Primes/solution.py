# 204. Count Primes

""" Count the number of prime numbers less than a non-negative number, n.

Example:

Input: 10
Output: 4
Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7. """


# class Solution:
#     def countPrimes(self, n: int) -> int:
#         if n <= 2:
#             return 0
#         res = [True] * n
#         res[0] = res[1] = False
#         for i in range(2, n):
#             if res[i] == True:
#                 for j in range(i, int((n-1)/i+1)):
#                     res[i*j] = False
#         return sum(res)

# class Solution:
#     def countPrimes(self, n: int) -> int:
#         if n <= 2:
#             return 0
#         res = [False] * n
#         res[0] = res[1] = False
#         for i in range(2, n):
#             if not res[i]:
#                 for j in range(i, int((n-1)/i+1)):
#                     res[i*j] = True
#         count = 0
#         for i in range(2, n):
#             if not res[i]:
#                 count += 1
#         return count


class Solution:
    def countPrimes(self, n: int) -> int:
        if n < 3: return 0     #  No prime number less than 2
        lst = [1] * n          #  create a list for marking numbers less than n
        lst[0] = lst[1] = 0    #  0 and 1 are not prime numbers
        m = 2
        while m * m < n:       #  we only check a number (m) if its square is less than n
            if lst[m] == 1:    #  if m is already marked by 0, no need to check its multiples.
			
			    #  If m is marked by 1, we mark all its multiples from m * m to n by 0. 
			    #  1 + (n - m * m - 1) // m is equal to the number of multiples of m from m * m to n
                lst[m * m: n: m] = [0] *(1 + (n - m * m - 1) // m)
				
			#  If it is the first iteration (e.g. m = 2), add 1 to m (e.g. m = m + 1; 
			#  which means m will be 3 in the next iteration), 
            #  otherwise: (m = m + 2); This way we avoid checking even numbers again.	
            m += 1 if m == 2 else 2
        return sum(lst)

q = Solution()
q
p = q.countPrimes(52)
p
