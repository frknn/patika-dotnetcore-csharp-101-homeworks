using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList sayilar = new ArrayList();
      ArrayList asalSayilar = new ArrayList();
      ArrayList asalOlmayanSayilar = new ArrayList();
      Console.WriteLine("20 adet pozitif sayi girisi yapmaniz bekleniyor...");

      while (sayilar.Count < 20)
      {
        Console.WriteLine("{0}. pozitif sayiyi giriniz: ", sayilar.Count + 1);
        bool ok = int.TryParse(Console.ReadLine(), out int girdi);
        if (girdi <= 0 || !ok)
        {
          Console.WriteLine("Girdiniz pozitif bir sayi degil, tekrar deneyin.");
        }
        else
        {
          sayilar.Add(girdi);
        }
      }

      foreach (int sayi in sayilar)
      {
        if (asalMi(sayi))
        {
          asalSayilar.Add(sayi);
        }
        else
        {
          asalOlmayanSayilar.Add(sayi);
        }
      }

      Console.WriteLine("-------------");

      Console.WriteLine("\n---ASAL SAYILAR---\n");

      asalSayilar.Sort();
      asalSayilar.Reverse();
      foreach (int sayi in asalSayilar)
      {
        Console.Write(sayi + " ");
      }
      Console.WriteLine("\nEleman Sayisi: " + asalSayilar.Count);
      int asalToplam = 0;
      foreach (int sayi in asalSayilar)
      {
        asalToplam += sayi;
      }
      Console.WriteLine("Ortalama: " + (double)((double)asalToplam / (double)asalSayilar.Count));


      Console.WriteLine("\n---ASAL OLMAYAN SAYILAR---\n");

      asalOlmayanSayilar.Sort();
      asalOlmayanSayilar.Reverse();
      foreach (int sayi in asalOlmayanSayilar)
      {
        Console.Write(sayi + " ");
      }
      Console.WriteLine("\nEleman Sayisi: " + asalOlmayanSayilar.Count);
      int asalOlmayanToplam = 0;
      foreach (int sayi in asalOlmayanSayilar)
      {
        asalOlmayanToplam += sayi;
      }
      Console.WriteLine("Ortalama: " + ((double)asalOlmayanToplam / (double)asalOlmayanSayilar.Count));
    }

    static bool asalMi(int sayi)
    {
      if (sayi == 1) return false;
      if (sayi == 2) return true;

      var limit = Math.Ceiling(Math.Sqrt(sayi));

      for (int i = 2; i <= limit; ++i)
      {
        if (sayi % i == 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
