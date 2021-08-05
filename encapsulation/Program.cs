using System;

namespace encapsulation
{
  class Program
  {
    static void Main(string[] args)
    {
      Ogrenci ogr1 = new Ogrenci("Furkan", "Setbasi", 287, 2);
      ogr1.BilgileriYaz();

      Console.WriteLine("---------");

      ogr1.SinifiDusur();
      ogr1.BilgileriYaz();

      Console.WriteLine("---------");

      ogr1.SinifiDusur();
      ogr1.BilgileriYaz();

    }
  }

  class Ogrenci
  {
    private string ad;
    private string soyad;
    private int no;
    private int sinif;

    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public int No { get => no; set => no = value; }
    public int Sinif
    {
      get => sinif;
      set
      {
        if (value < 1)
        {
          Console.WriteLine("Sınıf 1'den küçük olamaz.");
          sinif = 1;
        }
        else
        {
          sinif = value;
        }
      }
    }

    public Ogrenci(string ad, string soyad, int no, int sinif)
    {
      Ad = ad;
      Soyad = soyad;
      No = no;
      Sinif = sinif;
    }

    public Ogrenci()
    {
    }

    public void BilgileriYaz()
    {
      Console.WriteLine("Ad: {0}", this.Ad);
      Console.WriteLine("Soyad: {0}", this.Soyad);
      Console.WriteLine("No: {0}", this.No);
      Console.WriteLine("Sinif: {0}", this.Sinif);
    }

    public void SinifiArtir()
    {
      this.Sinif = this.Sinif + 1;
    }

    public void SinifiDusur()
    {
      this.Sinif = this.Sinif - 1;
    }

  }
}
