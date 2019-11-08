import unittest
from selenium import webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By
#from __builtin__ import classmethod


class searchTests(unittest.TestCase):
    @classmethod
    def setUp(self):
        # create new chrome web webdriver
        self.driver = webdriver.Firefox()
        self.driver.implicitly_wait(30)
        self.driver.maximize_window()
        
        self.driver.get("http://www.opencart.com/")
    
  #  def test_search_field(self):
    #    self.assertTrue(self.is_element_present(By.NAME, "filter_search"))
     #   pass"""
    
    def test_search_by_category(self):
        #get the link text
        self.get_link = self.driver.find_element_by_link_text("Marketplace")
        self.get_link.click()
        
      #  test_search_field()
        #get the search box
        self.get_search_field = self.driver.find_element_by_name("filter_search")
        
        self.get_search_field.clear()
        
        #enter the search word
        self.get_search_field.send_keys("cars")
        #self.get_search_field.submit()
        
        #get all anchor element
        products = self.driver.find_element_by_link_text("LitExtension: OpenCart to OpenCart Migration")
        products.click()
        #self.assertEqual(2, len(products))

    @classmethod
    def tearDown(self):
        #close the browser window
        self.driver.quit()
        
    def is_element_present(self, how, what):
        # how: by locator type
        # what: locator value
        try:
            self.driver.find_element(by=how, value=what)
        except NoSuchElementException:
            return False
        return True

if __name__ == '__main__':
    unittest.main()

