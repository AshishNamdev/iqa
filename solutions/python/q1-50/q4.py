'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''
VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

'''
half pyramid
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5
'''
n = 5
for i in range(1, n+1):
    print ("%s " %i * i)

print("\n")

'''
Inverted half pyramid
5 5 5 5 5
4 4 4 4
3 3 3
2 2
1
'''
n = 5
for i in range(n, 0, -1):
    print ("%s " %i * i)

print("\n")

'''
Triangle
      1
     2 2
    3 3 3
   4 4 4 4
  5 5 5 5 5
'''
n = 5
for i in range(1, n+1):
    print (' ' * (n - i)),
    print (" %s" %i * i)

print("\n")

'''
Full pyramid
          1
        2 2 2
      3 3 3 3 3
    4 4 4 4 4 4 4
  5 5 5 5 5 5 5 5 5
'''
n = 5
for i in range(1, n+1):
    print ('  ' * (n - i)),
    print (" %s" %i * (2 * i - 1))

print("\n")

'''
Inverted full pyramid

  5 5 5 5 5 5 5 5 5
    4 4 4 4 4 4 4
      3 3 3 3 3
        2 2 2
          1

'''
n = 5
for i in range(n, 0, -1):
    print ('  ' * (n - i)),
    print (" %s" %i * (2 * i - 1))

print("\n")