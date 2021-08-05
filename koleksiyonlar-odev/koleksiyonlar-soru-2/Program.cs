using System;
using System.Linq;

namespace koleksiyonlar_soru_2
{
  class Program
  {
    static void Main(string[] args)
    {
      // Soruda belirtilmediği için girdi kontrolü yapmadım.
      int[] sayilar = new int[20];
      int[] maxUc = new int[3];
      int[] minUc = new int[3];

      for (int i = 0; i < 20; i++)
      {
        Console.Write("{0}. sayiyi giriniz: ", i + 1);
        sayilar[i] = int.Parse(Console.ReadLine());
      }

      Array.Sort(sayilar);

      for (int i = 0; i < 3; i++)
      {
        maxUc[i] = sayilar[(sayilar.Length - 3) + i];
        minUc[i] = sayilar[i];
      }

      Console.Write("Min 3: ");
      for (int i = 0; i < 3; i++)
      {
        Console.Write(minUc[i] + " ");
      }
      Console.Write("\nMax 3: ");
      for (int i = 0; i < 3; i++)
      {
        Console.Write(maxUc[i] + " ");
      }

      Console.WriteLine("\nMax Array Ort: " + (double)maxUc.Average());
      Console.WriteLine("Min Array Ort: " + (double)minUc.Average());
      double ortToplam = maxUc.Average() + minUc.Average();
      Console.WriteLine("Ortalama Toplamlari: " + ortToplam);
    }
  }
}
