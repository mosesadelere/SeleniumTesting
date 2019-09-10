import unittest
from Calculate import Calculate
class TestCalculate(unittest.TestCase):
    def setUp(self):
        self.calc = Calculate()
    
    def test_add_method_return_correct_result(self):
        self.assertEqual(7, self.calc.add(2, 5))
    def test_add_method_raised_TypeError_if_not_int(self):
        self.assertRaises(TypeError, self.calc.add("Hello", "World"))


if __name__ == '__main__':
    unittest.main()
