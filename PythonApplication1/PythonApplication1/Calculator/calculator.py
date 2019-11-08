class Calculator(object):
    """description of class"""
    def add(self,x,y):
        if isinstance(x, (int, float)) and isinstance(y, (int, float)):
            return x + y
        else:
            raise TypeError("Values must be numeric, {} and {}".format(type(x), type(y)))


if __name__ == '__main__':
    calc = Calculator()
    result = calc.add(3,5)
    print(result)


