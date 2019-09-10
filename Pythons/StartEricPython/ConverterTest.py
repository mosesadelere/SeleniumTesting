import unittest
from converter import RomanConverter

class RomanNumeralConverterTest(unittest.TestCase):
    def test_parse_millenia(self):
        self.millenia = 1000
        value = RomanConverter("M")
        self.assertEquals(self.millenia,  value.convert_to_decimal())
        
    def test_parse_century(self):
        self.century = 100
        value = RomanConverter("C")
        self.assertEquals(self.century,  value.convert_to_decimal())
        
    def test_parse_half_century(self):
        self.halfcentury = 50
        value = RomanConverter("L")
        self.assertEquals(self.halfcentury,  value.convert_to_decimal())
        
    def test_parse_decade(self):
        self.decade = 10
        value = RomanConverter("X")
        self.assertEquals(self.decade,  value.convert_to_decimal())
        
    def test_parse_half_decade(self):
        self.half_decade = 5
        value = RomanConverter("V")
        self.assertEquals(self.half_decade,  value.convert_to_decimal())
        
    def test_parse_one(self):
        self.one = 1
        value = RomanConverter("I")
        self.assertEquals(self.one,  value.convert_to_decimal())
        
    def test_parse_empy(self):
        value = RomanConverter("")
        self.assertTrue(value.convert_to_decimal().__eq__(0))
        self.assertFalse(value.convert_to_decimal().__gt__(0))
        
    def test_parse_roman_numeral(self):
        value = RomanConverter(None)
        self.assertRaises(TypeError,  value.convert_to_decimal())
        
if __name__ == '__main__':
    unittest.main()
