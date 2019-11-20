'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''
## Q2
### Given following phrase, you need to provide the **count of word starts with letter 'b'** along with **individual word and it's length**
	
#   Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast

VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

test_data = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast"

test_data = {word: len(word) for word in test_data.split() if word.upper().startswith('B')}

print ("Total words start with 'b' or 'B' = %s" % len(test_data.keys()))

for key, val in test_data.items():
    print ("Word '%s', length = %s" % (key, val))
