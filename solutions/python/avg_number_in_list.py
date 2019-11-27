'''
Created on Nov 17, 2019

@author: Ashish Namdev
'''

## Q7 Programming
### Can you write a program to find the average of numbers in a list / array?

VERSION = '1.0.0'
DATE = '2019-11-17'
UPDATED = '2019-11-17'

n = 10
a = [i for i in range(1, n + 1)]
avg = sum(a)/n
print("Average of elements in the %s = %.1f" % (a, avg))

