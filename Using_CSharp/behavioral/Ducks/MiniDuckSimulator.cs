using System;

namespace Ducks.Ducks {
  class MiniDuckSimulator {
    public static void Main(string[] args) {

      Duck mallard = new MallardDuck();
      Console.WriteLine("==================\nI'm a Mallard:");
      mallard.PerformQuack();
      mallard.PerformFly();

      // Setting behavior dynamically:
      Duck model = new ModelDuck();
      Console.WriteLine("==================\nI'm a Model Duck:");
      // Use Fly behavior currently set in the code:
      model.PerformFly();

      // Now set a new Fly behavior dynamically:
      model.SetFlyBehavior(new FlyRocketPowered());
      model.PerformFly();

    }
  }
}
