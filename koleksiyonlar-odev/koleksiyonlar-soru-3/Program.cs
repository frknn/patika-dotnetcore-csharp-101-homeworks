using System;
using System.Collections.Generic;

namespace koleksiyonlar_soru_3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bir cumle giriniz: ");
      string cumle = Console.ReadLine();
      List<char> seslilerListesi = new List<char>();
      foreach (char harf in cumle)
      {
        if (sesliMi(harf)) seslilerListesi.Add(harf);
      }

      char[] seslilerDizisi = seslilerListesi.ToArray();

      Array.Sort(seslilerDizisi);

      foreach (char harf in seslilerDizisi)
      {
        Console.Write(harf + " ");
      }
    }
    static bool sesliMi(char harf)
    {
      string sesliHarfler = "aeıioöuü";
      if (sesliHarfler.Contains(harf))
      {
        return true;
      }
      return false;
    }
  }
}
