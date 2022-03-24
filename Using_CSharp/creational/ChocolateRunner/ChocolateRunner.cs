namespace Chocolate {
  public class ChocolateRunner  {
    public static void Main(string[] args)  {

      ChocolateBoiler.Instance.Fill();
      ChocolateBoiler.Instance.Boil();
      ChocolateBoiler.Instance.Drain();

      ChocolateBoiler.Instance.Boil();

    }
  }
}
