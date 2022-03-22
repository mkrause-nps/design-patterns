#!/usr/bin/env

# The duck base class.

class Duck:

    # Instance variables that hold a reference to a specific behavior at runtime.
    fly_behavior = None
    quack_behavior = None

    def set_fly_behavior(self, fly_behavior):
        self.fly_behavior = fly_behavior

    def set_quack_behavior(self, quack_behavior):
        self.quack_behavior = quack_behavior

    def display(self):
        raise NotImplementedError

    def perform_fly(self):
        self.fly_behavior.fly()

    def perform_quack(self):
        self.quack_behavior.quack()

    def swim(self):
        print("All ducks float, even decoys")
