#!/usr/bin/env python3

# Singleton Design Pattern

import threading


class SingletonError(Exception):
    pass


class Singleton(type):
    _instances = {}  # instance dictionary
    _lock = threading.Lock()

    def __call__(cls, *args, **kwargs):
        if cls not in cls._instances:
            with cls._lock:
                # Another thread could have created the instance
                # before we acquired the lock. Check whether the
                # instance is still nonexistent.
                if cls not in cls._instances:
                    print(f"Instance {cls} is not in instances dictionary")
                    cls._instances[cls] = super(Singleton, cls).__call__(*args, **kwargs)
        return cls._instances[cls]


class ChocolateBoiler(metaclass=Singleton):
    def __init__(self):
        self.empty = True
        self.boiled = False

    def fill(self):
        if not self.empty:
            print("Can't fill - boiler not empty!")
            #raise SingletonError
        self.empty = False
        self.boiled = False
        print("Filling boiler")

    def boil(self):
        if not self.empty and not self.boiled:
            print("Boiling mixture")
            self.boiled = True
            self.empty = False
        else:
            print("Empty or boiled already.")

    def drain(self):
        if not self.empty and self.boiled:
            #raise SingletonError
            self.empty = True
            self.boiled = False
            print("Draining boiler")
        else:
            print("Won't drain: either empty or not yet boiled...")

    def is_empty(self):
        return self.empty

    def is_boiled(self):
        return self.boiled


def chocolate_controller() -> None:
    print(f"Instance dictionary in Singleton has {len(Singleton._instances.keys())} instance")
    boiler = ChocolateBoiler()
    print(f"Instance dictionary in Singleton has {len(Singleton._instances.keys())} instance")
    boiler.fill()
    print("\n")

    print("Trying to create a second instance of a singleton:")
    boiler2 = ChocolateBoiler()
    boiler2.drain()

    boiler.boil()
    boiler2.drain()

    print(f'Is boiler2 an instance: {boiler2 is boiler}')
    print(f"Instance dictionary in Singleton has {len(Singleton._instances.keys())} instance")


if __name__ == '__main__':
    chocolate_controller()
