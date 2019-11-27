'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''

## Q4-Programming
### Print following patterns

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

def half_pyramid():
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
def inverted_half_pyramid():
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
def triangle():
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
def full_pyramid():
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
def inverted_full_pyramid():
    for i in range(n, 0, -1):
        print ('  ' * (n - i)),
        print (" %s" %i * (2 * i - 1))
    print("\n")

'''
Pascal's triangle
           1
         1   1
       1   2   1
     1   3   3    1
   1  4    6   4   1
 1  5   10   10  5   1
'''
def pascals_triangle():
    val = 1
    for i in range(0, n+1):
        print ('  ' * (n - i)),
        for j in range(0, i+1):
            val = 1 if (i == 0 or j == 0)\
                          else val * (i - j + 1) / j
            print ("%4d" % val),
        print("\n")

'''
Floyd's Triangle
 1
 2  3
 4  5  6
 7  8  9 10
'''
def floyds_triangle():
    no = 1
    for i in range(1, n+1):
        for j in range(1, i):
            print ("%1d" % no),
            no += 1
        print("\n")

half_pyramid()
inverted_half_pyramid()
triangle()
full_pyramid()
inverted_full_pyramid()
pascals_triangle()
floyds_triangle()