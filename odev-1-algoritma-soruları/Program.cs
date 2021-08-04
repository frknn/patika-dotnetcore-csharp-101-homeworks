using System;

namespace odev_1_algoritma_soruları
{
  class Program
  {
    static void Main(string[] args)
    {

      // SORU 1

      Console.WriteLine("Pozitif bir sayi girin: ");
      int girdi = int.Parse(Console.ReadLine());
      int[] arr = new int[girdi];
      for (int i = 0; i < girdi; i++)
      {
        Console.WriteLine("{0}. sayıyı girin", i + 1);
        arr[i] = int.Parse(Console.ReadLine());
      }

      Console.Write("Girilen çift sayılar: ");
      foreach (int i in arr)
      {
        if (i % 2 == 0) Console.Write(i + " ");
      }

      // SORU 2

      // Console.WriteLine("Sayi adedini girin: ");
      // int adet = int.Parse(Console.ReadLine());
      // Console.WriteLine("Boleni girin: ");
      // int bolen = int.Parse(Console.ReadLine());
      // int[] arr2 = new int[adet];
      // for (int i = 0; i < adet; i++)
      // {
      //   Console.WriteLine("{0}. sayıyı girin", i + 1);
      //   arr2[i] = int.Parse(Console.ReadLine());
      // }
      // Console.Write("Bolene tam bolunen ya da esit olan sayilar: ");
      // foreach (int i in arr2)
      // {
      //   if (i % bolen == 0 || i == bolen) Console.Write(i + " ");
      // }

      // SORU 3

      // Console.WriteLine("Kelime adedini girin: ");
      // int kelimeAdedi = int.Parse(Console.ReadLine());
      // string[] kelimeArrayi = new string[kelimeAdedi];
      // for (int i = 0; i < kelimeAdedi; i++)
      // {
      //   Console.WriteLine("{0}. kelimeyi girin: ", i + 1);
      //   kelimeArrayi[i] = Convert.ToString(Console.ReadLine());
      // }
      // foreach (string kelime in kelimeArrayi)
      // {
      //   Console.WriteLine(kelime);
      // }

      // SORU 4

      // Console.WriteLine("Bir cumle girin: ");
      // string cumle = Convert.ToString(Console.ReadLine());
      // int kelimeSayisi = 0;
      // int harfSayisi = 0;
      // foreach (string kelime in cumle.Split(" "))
      // {
      //   kelimeSayisi++;
      //   harfSayisi += kelime.Length;
      // }

      // Console.WriteLine("Cumlede {0} kelime, {1} harf var.", kelimeSayisi, harfSayisi);
    }
  }
}
