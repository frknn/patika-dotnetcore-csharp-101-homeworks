using System;

namespace enumlar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GUNLER.PAZARTESI);
      Console.WriteLine((int)GUNLER.PAZAR);

      int sicaklik = 23;
      if (sicaklik <= (int)HAVA_DURUMU.NORMAL)
      {
        Console.WriteLine("Hava dışarı çıkmak için soğuk.");
      }
      else if (sicaklik >= (int)HAVA_DURUMU.SICAK)
      {
        Console.WriteLine("Hava dışarı çıkmak için çok sıcak.");
      }
      else if (sicaklik >= (int)HAVA_DURUMU.NORMAL && sicaklik < (int)HAVA_DURUMU.SICAK)
      {
        Console.WriteLine("Haydi dışarı çıkalım.");
      }
    }
  }

  enum GUNLER
  {
    PAZARTESI = 1,
    SALI,
    CARSAMBA,
    PERSEMBE,
    CUMA,
    CUMARTESI = 99,
    PAZAR
  }

  enum HAVA_DURUMU
  {
    SOGUK = 5,
    NORMAL = 20,
    SICAK = 25,
    COK_SICAK = 30
  }
}
