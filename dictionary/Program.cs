using System;
using System.Collections.Generic;

namespace dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
      kullanicilar.Add(1, "furkan");
      kullanicilar.Add(2, "hakan");
      kullanicilar.Add(3, "mehmet");
      kullanicilar.Add(4, "sukran");

      Console.WriteLine("-----------");

      Console.WriteLine(kullanicilar[1]);
      foreach (var kullanici in kullanicilar)
      {
        Console.WriteLine(kullanici);
      }

      Console.WriteLine(kullanicilar.Count);

      Console.WriteLine("-----------");


      Console.WriteLine(kullanicilar.ContainsKey(2));
      Console.WriteLine(kullanicilar.ContainsValue("mehmet"));

      Console.WriteLine("-----------");

      kullanicilar.Remove(1);
      foreach (var kullanici in kullanicilar)
      {
        Console.WriteLine(kullanici);
      }

      Console.WriteLine("-----------");

      // Keys and Values
      foreach (int key in kullanicilar.Keys)
      {
        Console.WriteLine(key);

      }
      foreach (string value in kullanicilar.Values)
      {
        Console.WriteLine(value);
      }

    }
  }
}
