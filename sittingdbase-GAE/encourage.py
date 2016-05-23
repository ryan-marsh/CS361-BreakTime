import webapp2
from google.appengine.ext import ndb
import db_defs
import json
import random

class Encouragement(webapp2.RequestHandler):
	def get(self):
		q = db_defs.Encouragements.query()
		fetch = q.fetch()
		encourage = [x.to_dict() for x in fetch]
		encourage = random.choice(encourage)
		self.response.write(json.dumps(encourage))



