import unittest;
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

#driver = webdriver.Firefox()
#driver.get("http://www.python.org")
#assert "Python" in driver.title
#elem = driver.find_element_by_name("q")
#elem.clear()
#elem.send_keys("ball")
#if elem.send_keys(Keys.RETURN):
#    assert "Found!" in driver.page_source
#else:
#    assert "No result found." not in driver.page_source
#driver.close()

class PythonOrgSearch(unittest.TestCase):

    def setUp(self):
        self.driver = webdriver.Firefox()

    def test_search_in_python_org(self):
        driver = self.driver
        driver.get("http://www.python.org")
        self.assertIn("Python", driver.title)
        elem = driver.find_element_by_name("q")
        elem.send_keys("pycon")
        elem.send_keys(Keys.RETURN)
        assert "No results found!" not in driver.page_source

    def tearDown(self):
        self.driver.close()

    def printStr():
        print("It is happening!")
if __name__ == "__main__":
    unittest.main()

