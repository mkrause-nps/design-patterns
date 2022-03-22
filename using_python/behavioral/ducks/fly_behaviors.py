#!/usr/bin/env python3

from fly_behavior import FlyBehavior

# Implementations of concrete fly behaviors.


class FlyWithWings(FlyBehavior):

    # We don't need a constructor.

    def fly(self):
        print("I'm flying with wings")


class FlyNoWay(FlyBehavior):
    def fly(self):
        print("I can't fly")


class FlyRocketPowered(FlyBehavior):
    def fly(self):
        print("I'm flying with a rocket")
