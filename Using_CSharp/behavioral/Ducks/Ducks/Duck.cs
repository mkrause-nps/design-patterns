using System;

namespace Ducks.Ducks { 
	public abstract class Duck {

    // Maintain references to the each behavior interface:
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    
		public Duck() { }

    //-------------------------------------------------------------------------
    public abstract void Display();

    //-------------------------------------------------------------------------
    public void PerformFly() {
      flyBehavior.Fly();
    }

    //-------------------------------------------------------------------------
    public void PerformQuack() {
      quackBehavior.QuackBehavior();
    }


    //-------------------------------------------------------------------------
    // Call this method anytime we want to change fly behavior dynamically.
    public void SetFlyBehavior(IFlyBehavior fb) {
      flyBehavior = fb;
    }

    //-------------------------------------------------------------------------
    // Call this method anytime we want to change quack behavior dynamically.
    public void SetQuackBehavior(IQuackBehavior qb) {
      quackBehavior = qb;
    }


    //-------------------------------------------------------------------------
    public void Swim() {
      Console.WriteLine("All ducks float, even decoys");
    }
	}
}
