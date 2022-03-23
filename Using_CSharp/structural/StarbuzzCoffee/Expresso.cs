namespace StarbuzzCoffee {
  public class Espresso : Beverage {
    public Espresso() {
      _description = "Espresso";
    }

    public override float Cost() {
      return 1.99f;
    }
  }
}
