using System;

namespace Ducks {
  public class Squeak : IQuackBehavior {
    public void QuackBehavior() {
      Console.WriteLine("Squeak");
    }
  }
}
