#!/usr/bin/env python3

from duck import Duck
from fly_behaviors import FlyWithWings, FlyNoWay, FlyRocketPowered
from quack_behaviors import StandardQuack, MuteQuack, Squeak

# Contains classes that contain concrete types of ducks.


class MallardDuck(Duck):
    # Set concrete instance behaviors:
    fly_behavior = FlyWithWings()
    quack_behavior = StandardQuack()

    @staticmethod
    def display():
        print("I'm a mallard duck")


class ModelDuck(Duck):
    fly_behavior = FlyNoWay()
    quack_behavior = MuteQuack()

    @staticmethod
    def display():
        print("I'm a model duck - I can't fly or quack")
