using System;

namespace Ducks {
	public class MuteQuack : IQuackBehavior {
		public void QuackBehavior() {
			Console.WriteLine("<< Silencio >>");
		}
	}
}
