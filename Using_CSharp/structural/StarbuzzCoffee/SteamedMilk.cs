namespace StarbuzzCoffee {
  public class SteamedMilk : CondimentDecorator {

    // Maintain a Beverage instance variable:
    Beverage beverage;

    public SteamedMilk(Beverage beverage) {
      this.beverage = beverage;
    }

    public override string GetDescription() {
      return this.beverage.GetDescription() + ", Steamed Milk";
    }

    public override float Cost() {
      return this.beverage.Cost() + 0.1f;
    }
  }
}