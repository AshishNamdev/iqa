'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''

## Q5-Programming
### Write Code to Run `ipconfig` command and print output on screen.

VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

import subprocess

print (subprocess.check_output('ipconfig'))

