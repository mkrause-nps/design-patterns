#!/usr/bin/env python3

# Decorator Design Pattern

from starbuzz_base_classes import Beverage, CondimentDecorator

#################################################
# Implement concrete component classes:


class HouseBlend(Beverage):
    def __init__(self):
        super().__init__()
        self.description = "House Blend Coffee"

    def cost(self) -> float:
        return 0.89


class Espresso(Beverage):
    def __init__(self):
        super().__init__()
        self.description = "Espresso"

    def cost(self) -> float:
        return 1.99


class DarkRoast(Beverage):
    def __init__(self):
        super().__init__()
        self.description = "Dark, French Roast Coffee"

    def cost(self) -> float:
        return 0.99


class Decaf(Beverage):
    def __init__(self):
        super().__init__()
        self.description = "Decaffeinated Coffee"

    def cost(self) -> float:
        return 1.05


#################################################
# Implement the concrete condiments classes:
# Each of them maintains a reference to the Beverage abstract class to inherit the cost method.


class Soy(CondimentDecorator):
    def __init__(self, beverage: Beverage):
        super().__init__()
        self.beverage = beverage

    def get_description(self):
        return self.beverage.get_description() + ", Soy"

    def cost(self) -> float:
        return self.beverage.cost() + 0.15


class Mocha(CondimentDecorator):
    def __init__(self, beverage: Beverage):
        super().__init__()
        self.beverage = beverage

    def get_description(self):
        return self.beverage.get_description() + ", Mocha"

    def cost(self) -> float:
        return self.beverage.cost() + 0.2


class SteamedMilk(CondimentDecorator):
    def __init__(self, beverage: Beverage):
        super().__init__()
        self.beverage = beverage

    def get_description(self):
        return self.beverage.get_description() + ", Steamed Milk"

    def cost(self) -> float:
        return self.beverage.cost() + 0.1


class Whip(CondimentDecorator):
    def __init__(self, beverage: Beverage):
        super().__init__()
        self.beverage = beverage

    def get_description(self):
        return self.beverage.get_description() + ", Whipped Cream"

    def cost(self) -> float:
        return self.beverage.cost() + 0.1


#################################################
# Driver code:


def starbuzz_coffee():
    beverage = Espresso()
    print(beverage.get_description(), beverage.cost())

    beverage3 = HouseBlend()
    beverage3 = Mocha(beverage3)
    beverage3 = Mocha(beverage3)
    print(beverage3.get_description(), beverage3.cost())


if __name__ == "__main__":
    starbuzz_coffee()
