import webapp2

application = webapp2.WSGIApplication([
	('/', 'hello.Hello'),
	('/encourage', 'encourage.Encouragement'),
	('/stretch', 'stretch.Stretch'),
	('/addstretch', 'admin.AddStretch'),
	('/addencouragement', 'admin.AddEncouragement'),
], debug=True)