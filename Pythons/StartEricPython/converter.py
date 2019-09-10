class RomanConverter():
    def __init__(self, roman_numeral):
        self.roman_numeral = roman_numeral
        self.digit_manual = {"M" : 1000, "D" : 500,  "C" : 100,  "L" : 50,  "X" : 10,  "V" : 5,  "I" : 1}
        
    def convert_to_decimal(self):
        val = 0
        for num in self.roman_numeral:
            val += self.digit_manual[num]
        return val
        
