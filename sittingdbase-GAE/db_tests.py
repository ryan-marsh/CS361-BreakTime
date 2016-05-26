# Relevant database unit testing documentation:
# https://cloud.google.com/appengine/docs/python/tools/localunittesting


import sys

# These are LOCAL unit tests. The path arguments must point to the local Google
# App Engine SDK installation folder which begins with \Google
sys.path.insert(1, 'C:\\Program Files (x86)\Google\google_appengine')
sys.path.insert(1, 'C:\\Program Files (x86)\Google\google_appengine\lib\yaml\lib')

import unittest
from db_defs import Stretches
from db_defs import Encouragements

from google.appengine.ext import ndb
from google.appengine.ext import testbed
from google.appengine.api import memcache


class DatabaseTest(unittest.TestCase):

	# Testbed setup
	def setUp(self):
		self.testbed = testbed.Testbed()
		self.testbed.activate()
		self.testbed.init_datastore_v3_stub()
		self.testbed.init_memcache_stub()
		ndb.get_context().clear_cache()

	def tearDown(self):
		self.testbed.deactivate()


	# TESTS	

	# Add a Stretch entity to the Stretch table and test whether or not there
	# is only one entity in the table
	def testStretchInsertEntity(self):
		Stretches(name="name", description="descrip", imgURL="URL").put()
		self.assertEqual(1, len(Stretches.query().fetch(2)))

	# Add an Encouragement entity to the Encouragements table and test whether
	# or not there is only one entity in the table
	def testEncourageInsertEntity(self):
		Encouragements(description="descrip").put()
		self.assertEqual(1, len(Encouragements.query().fetch(2)))

	# Delete a Stretch entity from the Stretch table and test whether or not
	# there are zero entities in the table
	def testStretchDeleteEntity(self):
		entity = Stretches(name="name", description="descrip", imgURL="URL").put()
		entity.delete()
		self.assertEqual(0, len(Stretches.query().fetch(1)))

	# Delete an Encouragement entity from the Encouragements table and test
	# whether or not there are zero entities in the table
	def testEncourageDeleteEntity(self):
		entity = Encouragements(description="descrip").put()
		entity.delete()
		self.assertEqual(0, len(Encouragements.query().fetch(1)))


# Start tests
if __name__ == '__main__':
    unittest.main()