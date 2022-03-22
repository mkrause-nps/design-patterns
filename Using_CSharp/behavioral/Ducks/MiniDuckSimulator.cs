using System;

namespace Ducks {
  class MiniDuckSimulator {
    public static void Main(string[] args) {

      Duck mallard = new MallardDuck();
      mallard.PerformQuack();
      mallard.PerformFly();
    }
  }
}
