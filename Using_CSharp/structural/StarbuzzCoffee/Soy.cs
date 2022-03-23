namespace StarbuzzCoffee {
  public class Soy : CondimentDecorator {

    // Maintain a Beverage instance variable:
    Beverage beverage;

    public Soy(Beverage beverage) {
      this.beverage = beverage;
    }

    public override string GetDescription() {
      return this.beverage.GetDescription() + ", Soy Milk";
    }

    public override float Cost() {
      return this.beverage.Cost() + 0.15f;
    }
  }
}
