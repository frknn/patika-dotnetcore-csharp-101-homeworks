using System;
using System.Collections.Generic;

namespace generic_list
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> sayiListesi = new List<int>();
      sayiListesi.Add(1);
      sayiListesi.Add(5);
      sayiListesi.Add(4);
      sayiListesi.Add(3);
      sayiListesi.Add(70);
      sayiListesi.Add(99);

      List<string> renkListesi = new List<string>();
      renkListesi.Add("mavi");
      renkListesi.Add("kirmizi");
      renkListesi.Add("yesil");
      renkListesi.Add("mor");
      renkListesi.Add("turuncu");

      Console.WriteLine(sayiListesi.Count);
      Console.WriteLine(renkListesi.Count);

      foreach (int sayi in sayiListesi)
      {
        Console.WriteLine(sayi);
      }
      foreach (string renk in renkListesi)
      {
        Console.WriteLine(renk);
      }

      sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      sayiListesi.Remove(2);
      renkListesi.Remove("kirmizi");

      sayiListesi.RemoveAt(3);
      renkListesi.RemoveAt(0);

      sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      if (sayiListesi.Contains(99))
      {
        Console.WriteLine("Listede 99 var");
      }

      Console.WriteLine(sayiListesi.BinarySearch(99));

      string[] hayvanlar = { "kedi", "kopek", "kus" };
      List<string> hayvanlarListesi = new List<string>(hayvanlar);

      hayvanlarListesi.Clear();

      List<Kullanici> kullanicilar = new List<Kullanici>();

      Kullanici k1 = new Kullanici();
      k1.Isim = "furkan";
      k1.Soyisim = "setbasi";
      k1.Yas = 23;

      Kullanici k2 = new Kullanici() { Isim = "hakan", Soyisim = "setbasi", Yas = 19 };

      kullanicilar.Add(k1);
      kullanicilar.Add(k2);

      kullanicilar.ForEach(kullanici =>
      {
        Console.WriteLine("Ad: " + kullanici.Isim);
        Console.WriteLine("Soyad: " + kullanici.Soyisim);
        Console.WriteLine("Yas: " + kullanici.Yas);
      });
    }
  }

  public class Kullanici
  {
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
  }
}
