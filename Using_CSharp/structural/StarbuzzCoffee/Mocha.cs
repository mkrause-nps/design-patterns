namespace StarbuzzCoffee {
  public class Mocha : CondimentDecorator {

    // Maintain a Beverage instance variable:
    Beverage beverage;

    public Mocha(Beverage beverage) {
      this.beverage = beverage;
    }

    public override string GetDescription() {
      return this.beverage.GetDescription() + ", Mocha";
    }

    public override float Cost() {
      return this.beverage.Cost() + 0.2f;
    }
  }
}
