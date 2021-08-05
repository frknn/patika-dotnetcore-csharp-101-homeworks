using System;

namespace kurucu_metotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      Calisan calisan1 = new Calisan("Furkan", "Setbasi", 12345678, "IT");
      calisan1.CalisanBilgileri();

      Console.WriteLine("----------");

      Calisan calisan2 = new Calisan("Mert", "Kalem", 65985632, "IK");
      calisan2.CalisanBilgileri();

      Console.WriteLine("----------");

      Calisan calisan3 = new Calisan("Sertaç", "Çiftçi");
      calisan3.CalisanBilgileri();
    }
  }
  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan() { }

    public Calisan(string ad, string soyad, int no, string departman)
    {
      this.Ad = ad;
      this.Soyad = soyad;
      this.No = no;
      this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
      this.Ad = ad;
      this.Soyad = soyad;
    }

    public void CalisanBilgileri()
    {
      Console.WriteLine("Calisan Ad: {0}", Ad);
      Console.WriteLine("Calisan Soyad: {0}", Soyad);
      Console.WriteLine("Calisan No: {0}", No);
      Console.WriteLine("Calisan Departman: {0}", Departman);
    }
  }
}
