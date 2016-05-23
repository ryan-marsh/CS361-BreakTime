from google.appengine.ext import ndb

"""
class Model(ndb.Model):
	def to_dict(self):
		d = super(Model, self).to_dict()
		d['key'] = self.key.id()
		return d
"""
		
class Stretches(ndb.Model):
	name = ndb.StringProperty(required=True)
	description = ndb.StringProperty(required=True)
	imgURL = ndb.StringProperty(required=True)
	
	def to_dict(self):
		d = super(Stretches, self).to_dict()
		d['key'] = self.key.id()
		return d
	
class Encouragements(ndb.Model):
	description = ndb.StringProperty(required=True)
	
	def to_dict(self):
		d = super(Encouragements, self).to_dict()
		d['key'] = self.key.id()
		return d
