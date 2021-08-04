using System;

namespace array_methodlari
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
      foreach (int sayi in sayiDizisi)
      {
        Console.WriteLine(sayi);
      }

      Console.WriteLine("\n--------\n");

      Array.Sort(sayiDizisi);
      foreach (int sayi in sayiDizisi)
      {
        Console.WriteLine(sayi);
      }

      Console.WriteLine("\n--------\n");

      Array.Clear(sayiDizisi, 2, 2); // verilen indexten başlayarak n tane elemanı sıfırlar
      foreach (int sayi in sayiDizisi)
      {
        Console.WriteLine(sayi);
      }

      Console.WriteLine("\n--------\n");

      Array.Reverse(sayiDizisi);
      foreach (int sayi in sayiDizisi)
      {
        Console.WriteLine(sayi);
      }

      Console.WriteLine("\n--------\n");
      Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

      Console.WriteLine("\n--------\n");
      Array.Resize<int>(ref sayiDizisi, 9);
      sayiDizisi[8] = 99;
      foreach (int sayi in sayiDizisi)
      {
        Console.WriteLine(sayi);
      }
    }
  }
}
