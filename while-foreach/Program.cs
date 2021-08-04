using System;

namespace while_foreach
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Sayi Giriniz: ");
      int sayi = int.Parse(Console.ReadLine());
      int sayac = 1;
      int toplam = 0;
      while (sayac <= sayi)
      {
        toplam += sayac;
        sayac++;
      }
      Console.WriteLine(toplam / sayi);

      char c = 'a';
      while (c <= 'z')
      {
        Console.Write(c);
        c++;
      }

      // foreach
      string[] arabalar = { "AUDI", "BMW", "FORD", "MERCEDES" };
      foreach (string araba in arabalar)
      {
        Console.WriteLine(araba);
      }
    }
  }
}
