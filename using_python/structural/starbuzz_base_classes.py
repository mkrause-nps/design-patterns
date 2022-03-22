#!/usr/bin/env python3

import abc


class Beverage(abc.ABC):
    """Abstract base class (component) for all beverages"""

    def __init__(self):
        self.description = "Unknown beverage"

    def get_description(self):
        return self.description

    @abc.abstractmethod
    def cost(self) -> float:
        raise NotImplementedError


class CondimentDecorator(Beverage, abc.ABC):
    """Abstract base class decorator"""

    @abc.abstractmethod
    def get_description(self):
        raise NotImplementedError
