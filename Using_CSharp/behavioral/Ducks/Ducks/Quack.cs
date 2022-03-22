using System;

namespace Ducks {
	public class Quack : IQuackBehavior {
		public void QuackBehavior() {
			Console.WriteLine("Quack!");
		}
	}
}
