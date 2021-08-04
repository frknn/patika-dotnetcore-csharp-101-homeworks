using System;

namespace metotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 3;
      int b = 5;

      int sonuc = Topla(a, b);
      Metotlar ornek = new Metotlar();

      ornek.EkranaYazdir(Convert.ToString(sonuc));
      int sonuc2 = ornek.ArtirVeTopla(ref a, ref b);
      ornek.EkranaYazdir(Convert.ToString(sonuc2));
      ornek.EkranaYazdir(Convert.ToString(Topla(a, b)));

    }

    static int Topla(int a, int b)
    {
      return a + b;
    }
  }

  class Metotlar
  {
    public void EkranaYazdir(string veri)
    {
      Console.WriteLine(veri);
    }

    public int ArtirVeTopla(ref int d1, ref int d2)
    {
      d1 += 1;
      d2 += 1;
      return d1 + d2;
    }
  }
}
