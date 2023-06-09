import requests
import json
import sys
r = requests.get('https://codeforces.com/api/' + sys.argv[1])

from pprint import pprint
pprint(r.json())
pprint(type(r.json()))