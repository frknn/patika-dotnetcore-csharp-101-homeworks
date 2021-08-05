using System;

namespace interface_ornek
{
  class Program
  {
    static void Main(string[] args)
    {
      Focus focus = new Focus();
      Console.WriteLine(focus.HangiMarka().ToString());
      Console.WriteLine(focus.KacTekerlegiVar());
      Console.WriteLine(focus.StandartRenk().ToString());

      Console.WriteLine("---------------");

      Corolla corolla = new Corolla();
      Console.WriteLine(corolla.HangiMarka().ToString());
      Console.WriteLine(corolla.KacTekerlegiVar());
      Console.WriteLine(corolla.StandartRenk().ToString());

      Console.WriteLine("---------------");

      Civic civic = new Civic();
      Console.WriteLine(civic.HangiMarka().ToString());
      Console.WriteLine(civic.KacTekerlegiVar());
      Console.WriteLine(civic.StandartRenk().ToString());
    }
  }
}
