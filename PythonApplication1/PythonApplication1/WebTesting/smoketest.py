import unittest
from automateweb import searchTests

#class Test_smoketest(unittest.TestCase):
#    def test_A(self):
 #       self.fail("Not implemented")

#if __name__ == '__main__':
 #   unittest.main()
search_test = unittest.TestLoader().loadTestsFromTestCase(searchTests)
smoke_test = unittest.TestSuite(search_test)

unittest.TextTestRunner().run(smoke_test)