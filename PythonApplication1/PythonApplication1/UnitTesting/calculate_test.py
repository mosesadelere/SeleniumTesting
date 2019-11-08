import unittest
#from calculator import Calculator
#from PythonApplication1.Calculator import Calculator
from Calculator.calculator import Calculator



class Test_calculate_test(unittest.TestCase):
    def setUp(self):
        self.calc = Calculator()

    def test_add_method_returns_correct_result(self):
        self.assertEquals(23, self.calc.add(15,8))

    def test_add_method_raises_typeerror_if_values_not_numeric(self):
        self.assertRaises(TypeError, self.calc.add, 'hello', 'moses')

if __name__ == '__main__':
    unittest.main()
