using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList liste = new ArrayList();

      // liste.Add("furkan");
      // liste.Add(2);
      // liste.Add(true);
      // liste.Add('c');

      // elemanlara erişim
      // Console.WriteLine(liste[1]);
      // foreach (var item in liste)
      // {
      //   Console.WriteLine(item);
      // }

      Console.WriteLine("-------------");

      // AddRange
      // string[] renkler = { "kirmizi", "sari", "yesil" };
      List<int> sayilar = new List<int>() { 1, 2, 3, 5, 4 };
      // liste.AddRange(renkler);
      liste.AddRange(sayilar);

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("-------------");

      // Sort
      liste.Sort();
      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("-------------");

      // Binary Search
      Console.WriteLine(liste.BinarySearch(4));

      Console.WriteLine("-------------");

      // Reverse
      liste.Reverse();
      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("-------------");

      // Clear

      liste.Clear();
      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }
    }
  }
}
