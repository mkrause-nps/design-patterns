using System;

namespace Chocolate {

  /*
   * Uses the 4th version of a singleton class, thread-safe,
   * from https://csharpindepth.com/articles/singleton.
   * 
   * What's special here is that we get a thread-safe Singleton
   * creation without the need of a lock (or double lock).
   * 
   */

  public class ChocolateBoiler {

    private bool _empty;
    private bool _boiled;

    private static readonly ChocolateBoiler instance = new ChocolateBoiler();

    //-------------------------------------------------------------------------
    // Constructors: Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit.
    static ChocolateBoiler() { }

    private ChocolateBoiler() {
      _empty = true;
      _boiled = false;
    }

    //-------------------------------------------------------------------------
    public static ChocolateBoiler Instance {
      get{ return instance; }
    }

    //-------------------------------------------------------------------------
    public void Fill() {
      if (IsEmpty()) {
        _empty = false;
        _boiled = false;
        Console.WriteLine("Filling boiler...");
      }
      else {
        Console.WriteLine("Can't fill, boiler not empty!");
      }
    }

    //-------------------------------------------------------------------------
    public void Boil() {
      if (!IsEmpty() && !IsBoiled()) {
        _boiled = true;
        Console.WriteLine("Boiling mixture...");
      }
      else {
        Console.WriteLine("Can't boil, either empty or already boiled!");
      }
    }

    //-------------------------------------------------------------------------
    public void Drain() {
      if (!IsEmpty() && IsBoiled()) {
        _empty = true;
        Console.WriteLine("Draining mixture...");
      }
      else {
        Console.WriteLine("Can't drain - is empty!");
      }
    }

    //-------------------------------------------------------------------------
    private bool IsEmpty() {
      return _empty;
    }

    //-------------------------------------------------------------------------
    private bool IsBoiled() {
      return _boiled;
    }
  }
}
