import unittest
import HTMLTestRunner
import os
from automateweb import searchTests

dir = os.getcwd()
search_test = unittest.TestLoader().loadTestsFromTestCase(searchTests)

smoke_test = unittest.TestSuite(search_test)

outfile = open(dir + "\SmokeTestReport.html", "w")

runner = HTMLTestRunner.HTMLTestRunner(
    stream = outfile,
    title = 'Test Report',
    Description = 'Smoke Test')

runner.run(smoke_test)

