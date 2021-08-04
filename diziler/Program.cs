using System;

namespace diziler
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] renkler = new string[5];

      string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

      int[] dizi;
      dizi = new int[5];

      renkler[0] = "Mavi";
      dizi[3] = 10;

      Console.WriteLine(renkler[0]);
      Console.WriteLine(dizi[3]);
      Console.WriteLine(hayvanlar[1]);

      // klavyeden girilen n sayının ortalamasını hesaplama
      Console.WriteLine("Dizinin eleman sayısını giriniz: ");
      int uzunluk = int.Parse(Console.ReadLine());
      int[] sayiDizisi = new int[uzunluk];

      for (int i = 0; i < uzunluk; i++)
      {
        Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
        sayiDizisi[i] = int.Parse(Console.ReadLine());
      }

      int toplam = 0;
      foreach (int i in sayiDizisi)
      {
        toplam += i;
      }
      Console.WriteLine("Ortalama: " + Convert.ToDouble(toplam) / Convert.ToDouble(uzunluk));
    }
  }
}
