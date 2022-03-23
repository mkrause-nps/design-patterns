namespace StarbuzzCoffee {
  public class Decaf : Beverage {
    public Decaf() {
      _description = "Decaf";
    }

    public override float Cost() {
      return 1.05f;
    }
  }
}
