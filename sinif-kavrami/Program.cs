using System;

namespace sinif_kavrami
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Calisan calisan1 = new Calisan();
      calisan1.Ad = "Furkan";
      calisan1.Soyad = "Setbasi";
      calisan1.No = 12345678;
      calisan1.Departman = "IT";

      calisan1.CalisanBilgileri();

      Console.WriteLine("----------");

      Calisan calisan2 = new Calisan();
      calisan2.Ad = "Mert";
      calisan2.Soyad = "Kalem";
      calisan2.No = 65985632;
      calisan2.Departman = "IK";

      calisan2.CalisanBilgileri();

    }
  }

  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
      Console.WriteLine("Calisan Ad: {0}", Ad);
      Console.WriteLine("Calisan Soyad: {0}", Soyad);
      Console.WriteLine("Calisan No: {0}", No);
      Console.WriteLine("Calisan Departman: {0}", Departman);
    }
  }
}
