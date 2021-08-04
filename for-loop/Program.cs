using System;

namespace for_loop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lütfen bir sayi giriniz: ");
      int sayi = int.Parse(Console.ReadLine());
      for (int i = 1; i <= sayi; i++)
      {
        if (i % 2 == 1)
        {
          Console.WriteLine(i);
        }
      }

      int tekToplam = 0;
      int ciftToplam = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i % 2 == 0)
        {
          ciftToplam += i;
        }
        else
        {
          tekToplam += i;
        }
      }
      Console.WriteLine("Tek Sayilar Toplami: " + tekToplam);
      Console.WriteLine("Cift Sayilar Toplami: " + ciftToplam);

      // break ve continue
      for (int i = 1; i < 10; i++)
      {
        if (i == 4)
        {
          break;
        }
        Console.WriteLine(i);
      }

      for (int i = 1; i < 10; i++)
      {
        if (i == 4)
        {
          continue;
        }
        Console.WriteLine(i);
      }
    }
  }
}
