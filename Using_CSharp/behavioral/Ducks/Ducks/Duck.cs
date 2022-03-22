using System;

namespace Ducks
{
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
    public void Swim() {
      Console.WriteLine("All ducks float, even decoys");
    }
	}
}
