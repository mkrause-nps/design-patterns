namespace StarbuzzCoffee {
  public class DarkRoast : Beverage {
    public DarkRoast() {
      _description = "Dark Roast";
    }

    public override float Cost() {
      return 0.99f;
    }
  }
}
