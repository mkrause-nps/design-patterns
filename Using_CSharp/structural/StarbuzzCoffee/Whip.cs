namespace StarbuzzCoffee {
  public class Whip : CondimentDecorator {

    // Maintain a Beverage instance variable:
    Beverage beverage;

    public Whip(Beverage beverage) {
      this.beverage = beverage;
    }

    public override string GetDescription() {
      return this.beverage.GetDescription() + ", Whipped Cream";
    }

    public override float Cost() {
      return this.beverage.Cost() + 0.1f;
    }
  }
}
