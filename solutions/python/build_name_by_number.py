'''
Created on Nov 15, 2019

@author: Ashish Namdev
'''
## Q1 Programming
### You are given  random build number, from the following data format **you need to provide respective Build name**
'''
Build Number Range - Build Name
000-010 - Hourly
011-020 - Nightly
021-030 - Beta
031-040 - Test
101-199 - Release Candidate
201-300 - Release
'''

VERSION = '1.0.0'
DATE = '2019-11-15'
UPDATED = '2019-11-15'

data = '''000-010 = Hourly
011-020 = Nightly
021-030 = Beta
031-040 = Test
101-199 = Release Candidate
201-300 = Release
'''

dict_data = {dt.split('=')[0].strip() : dt.split('=')[-1].strip() for dt in data.splitlines()}
build_no = 300
build_name = None

for key, val in dict_data.items():
  if build_no >= int(key.split('-')[0]) and build_no <= int(key.split('-')[-1]):
    build_name = val

print (build_name)