namespace StarbuzzCoffee {
  public class HouseBlend : Beverage {
    public HouseBlend() {
      this._description = "House Blend";
    }

    public override float Cost() {
      return 0.89f;
    }
  }
}
