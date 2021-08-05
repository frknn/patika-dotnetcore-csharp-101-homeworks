using System;

namespace static_sinif_ve_uyeler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calisan sayisi: {0}", Calisan.CalisanSayisi);

      Calisan calisan1 = new Calisan("Furkan", "Setbasi", "IT");
      Console.WriteLine("Calisan sayisi: {0}", Calisan.CalisanSayisi);

      Calisan calisan2 = new Calisan("Kerem", "Topçu", "IK");
      Console.WriteLine("Calisan sayisi: {0}", Calisan.CalisanSayisi);

      Console.WriteLine("100 + 200 = {0}", Islemler.Topla(100, 200));
      Console.WriteLine("200 - 100 = {0}", Islemler.Cikar(200, 100));
    }
  }

  class Calisan
  {
    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi; }

    private string ad;
    private string soyisim;
    private string departman;

    static Calisan()
    {
      calisanSayisi = 0;
    }
    public Calisan(string ad, string soyisim, string departman)
    {
      this.ad = ad;
      this.soyisim = soyisim;
      this.departman = departman;
      calisanSayisi++;
    }
  }

  static class Islemler
  {
    public static long Topla(int sayi1, int sayi2)
    {
      return sayi1 + sayi2;
    }

    public static long Cikar(int sayi1, int sayi2)
    {
      return sayi1 - sayi2;
    }
  }
}
