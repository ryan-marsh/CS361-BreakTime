import webapp2
from google.appengine.ext import ndb
import db_defs
import json

class AddStretch(webapp2.RequestHandler):
	def post(self):
		"""Creates a Stretch entity
		POST Body Variables:
		name = ndb.StringProperty(required=True)
		description = ndb.StringProperty(required=True)
		imgURL = ndb.StringProperty(required=True)
		"""
		if 'application/json' not in self.request.accept:
			self.response.status = 406
			self.response.status_message = "OOPS.  API only supports application/json M1ME type"
			return
		#if everything okay, create new_stretch object from db_defs
		new_stretch = db_defs.Stretches()
		name = self.request.get('stretchname', default_value=None)
		description = self.request.get('stretchdescription', default_value=None)
		imgURL = self.request.get('url', default_value=None)
		
		if name:
			new_stretch.name = name
		else:
			self.response.status = 400
			self.response.status_message = "OOPS. Stretch Name Required."
			return
		if description:
			new_stretch.description = description
		else:
			self.response.status = 400
			self.response.status_message = "OOPS. Stretch Description Required."
			return
		if imgURL:
			new_stretch.imgURL = imgURL
		else:
			self.response.status = 400
			self.response.status_message = "OOPS. Strech Image URL Required."
			return
			
		key = new_stretch.put() #saves stretch into the database
		
		#self.response.write(json.dumps(new_stretch)) #writes the stretch with attributes we just made
		return
		
class AddEncouragement(webapp2.RequestHandler):
	def post(self):
		"""Creates an Encouragement entity
		POST Body Variables:
		description = ndb.StringProperty(required=True)
		"""
		if 'application/json' not in self.request.accept:
			self.response.status = 406
			self.response.status_message = "OOPS.  API only supports application/json M1ME type"
			return
			
		#if everything okay, create new_mod object from db_defs
		new_encouragement = db_defs.Encouragements()
		description = self.request.get('encouragement', default_value=None)

		if description:
			new_encouragement.description = description
		else:
			self.response.status = 400
			self.response.status_message = "OOPS. Encouragement description Required."
			return
		key = new_encouragement.put() #saves encouragement into the database
		
		#self.response.write(json.dumps(new_encouragement)) #writes the stretch with attributes we just made
		return

			


