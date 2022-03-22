#!/usr/bin/env python3

from ducks import MallardDuck, ModelDuck
from fly_behaviors import FlyRocketPowered


def mini_duck_simulator():

    mallard_duck = MallardDuck()
    mallard_duck.display()
    mallard_duck.perform_fly()
    mallard_duck.perform_quack()

    print("\n")

    model_duck = ModelDuck()
    model_duck.display()
    model_duck.perform_fly()
    model_duck.set_fly_behavior(FlyRocketPowered())
    model_duck.perform_fly()
    model_duck.perform_quack()


if __name__ == '__main__':
    mini_duck_simulator()

