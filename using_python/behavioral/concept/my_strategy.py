#!/usr/bin/env python3

from abc import ABCMeta
from abc import abstractmethod


class Context:
    """The object whose behavior will change."""

    @staticmethod
    def request(strategy):
        """The request is handled by the class passed in."""
        return strategy()


class IStrategy(metaclass=ABCMeta):
    """A strategy interface."""

    @staticmethod
    @abstractmethod
    def __str__():
        """Implement the __str__ dunder"""


class ConcreteStrategyA(IStrategy):
    def __str__(self):
        return "I'm ConcreteStrategyA"


class ConcreteStrategyB(IStrategy):
    def __str__(self):
        return "I'm ConcreteStrategyB"


class ConcreteStrategyC(IStrategy):
    def __str__(self):
        return "I'm ConcreteStrategyC"


# The client
CONTEXT = Context()

if __name__ == '__main__':
    print(CONTEXT.request(ConcreteStrategyA))
    print(CONTEXT.request(ConcreteStrategyB))
    print(CONTEXT.request(ConcreteStrategyC))
