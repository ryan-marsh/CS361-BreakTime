import webapp2
from google.appengine.ext import ndb
import db_defs
import json

class Hello(webapp2.RequestHandler):
	def get(self):
		self.response.write("Hello Sitting World - try /stretch or /encourage")