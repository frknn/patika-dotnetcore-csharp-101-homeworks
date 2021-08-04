using System;

namespace rekursif_extension
{
  class Program
  {
    static void Main(string[] args)
    {
      // recursive
      int result = 1;
      for (int i = 1; i < 5; i++)
      {
        result *= 3;
      }
      Console.WriteLine(result);

      Islemler islemler = new();
      Console.WriteLine(islemler.Expo(3, 4));

      // extension funcs
      string name = "Furkan SETBAŞI";
      bool sonuc = name.HasWhiteSpaces();
      if (sonuc) Console.WriteLine(name.RemoveWhiteSpaces());
      Console.WriteLine(name.MakeUpperCase());
      Console.WriteLine(name.MakeLowerCase());
      Console.WriteLine(name);

      int[] dizi = { 1, 3, 4, 2 };
      dizi.SortArray();
      dizi.EkranaYazdir();

      int a = 5;
      Console.WriteLine(a.IsEvenNumber());

      string str = "Furkan";
      Console.WriteLine(str.GetFirstChar());
    }
  }

  public class Islemler
  {
    public int Expo(int sayi, int us)
    {
      if (us < 2) return sayi;
      return Expo(sayi, us - 1) * sayi;
    }
  }

  public static class Extension
  {
    public static bool HasWhiteSpaces(this string param)
    {
      return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
      string[] kelimeler = param.Split(" ");
      return string.Join("", kelimeler);
    }
    public static string MakeUpperCase(this string param)
    {
      return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
      return param.ToLower();
    }

    public static void SortArray(this int[] param)
    {
      Array.Sort(param);
    }

    public static void EkranaYazdir(this int[] param)
    {
      foreach (int item in param)
      {
        Console.WriteLine(item);
      }
    }

    public static bool IsEvenNumber(this int param)
    {
      return param % 2 == 0;
    }

    public static string GetFirstChar(this string param)
    {
      return param.Substring(0, 1);
    }
  }
}
