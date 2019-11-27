'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''

## Q6 Programming
### Create a dictionary of values and it's squares of all even numbers up to 100

VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

print ({i : i * i for i in range(1, 101) if i % 2 == 0})

