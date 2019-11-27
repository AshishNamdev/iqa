'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''
## Q3 Programming
### Given following phrase, you need to **reverse the word starts with letter 'b'**
#	Betty got a bread with Butter which is bitter she wants better Bread and better for breakfast

VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

test_data = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast"
test_data = [word[::-1] if word.upper().startswith('B') else word for word in test_data.split()]
print (" ".join(test_data))
