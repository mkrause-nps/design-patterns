﻿namespace StarbuzzCoffee {
  public abstract class Beverage {
    protected string _description = "Unknown Beverage";

    public virtual string GetDescription() {
      return _description;
    }

    public abstract float Cost();
  }
}
