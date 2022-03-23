using System;

namespace StarbuzzCoffee {
  public class StarbuzzCoffee {

    public static void Main(string[] args) {

      // Just a plain espresso:
      Beverage beverage = new Espresso();
      Console.WriteLine(beverage.GetDescription()
        + " $" + beverage.Cost().ToString());


      // Now something more complicated:
      Beverage beverage2 = new HouseBlend();
      beverage2 = new Soy(beverage2);
      beverage2 = new Mocha(beverage2);
      beverage2 = new Mocha(beverage2);
      beverage2 = new Whip(beverage2);
      Console.WriteLine(beverage2.GetDescription()
        + " $" + beverage2.Cost());

    }
  }
}
