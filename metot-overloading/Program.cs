using System;

namespace metot_overloading
{
  class Program
  {
    static void Main(string[] args)
    {
      // out params
      string str = "999";
      bool sonuc = int.TryParse(str, out int outSayi);
      if (sonuc)
      {
        Console.WriteLine("Başarılı!");
        Console.WriteLine(outSayi);
      }
      else
      {
        Console.WriteLine("Başarısız!");
      }

      Metotlar metot = new Metotlar();
      metot.Topla(4, 5, out int toplamSonuc);
      Console.WriteLine(toplamSonuc);

      // method overloading
      int x = 111;
      metot.EkranaYazdir(Convert.ToString(x));
      metot.EkranaYazdir(111);
      metot.EkranaYazdir("Hello", "World!");

    }
  }

  class Metotlar
  {
    public void Topla(int a, int b, out int toplam)
    {
      toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
      Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
      Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)
    {
      Console.WriteLine(veri1 + " " + veri2);
    }
  }
}
