import webapp2
from google.appengine.ext import ndb
import db_defs
import json
import random

class Stretch(webapp2.RequestHandler):
	def get(self):
		q = db_defs.Stretches.query()
		fetch = q.fetch()
		stretch = [x.to_dict() for x in fetch]
		stretch = random.choice(stretch)
		self.response.write(json.dumps(stretch))
