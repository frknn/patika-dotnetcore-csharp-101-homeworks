using System;

namespace degiskenler
{
  class Program
  {
    static void Main(string[] args)
    {
      int deger2 = 3;
      string degisken = null;
      string Degisken = null;

      byte b = 1; // 1 byte
      sbyte sb = 1; // 1 byte

      short sh = 1; // 2 byte
      ushort ush = 1; // 2 byte

      Int16 i16 = 1; // 2 byte
      int i = 1; // 4 byte
      Int32 i32 = 1; // 4 byte
      Int64 i64 = 1; // 8 byte
      uint ui = 1; // 4 byte

      long l = 1; // 8 byte
      ulong ul = 1; // 8 byte

      float f = 1; // 4 byte
      double d = 1.0; // 8 byte
      decimal dcm = 1; // 16 byte

      char c = 'c'; // 2 byte
      string str = "str"; // sınırsız

      bool blt = true;
      bool blf = false;

      DateTime dt = DateTime.Now;

      Console.WriteLine(dt);

      object o1 = '1';
      object o2 = "1";
      object o3 = 1;
      object o4 = 1.0;

      // string ifadeler

      string str1 = string.Empty;
      str1 = "Furkan Setbaşı";

      string ad = "Furkan";
      string soyad = "Setbaşı";
      string adSoyad = ad + " " + soyad;

      // integer tanımlama ifadeleri

      int int1 = 1;
      int int2 = 2;
      int int3 = int1 * int2;

      // boolean

      bool boolean1 = 10 > 2; // true atar

      // Tip dönüşümleri

      string str20 = "20";
      int int20 = 20;
      string yeniDeger = str20 + int20.ToString();
      Console.WriteLine(yeniDeger); // çıktı 2020

      int int40 = int20 + Convert.ToInt32(str20);
      Console.WriteLine(int40); // çıktı 40

      int int402 = int20 + int.Parse(str20);
      Console.WriteLine(int402); // çıktı 40

      // DateTime

      string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
      Console.WriteLine(dateTime);

      string dateTime2 = DateTime.Now.ToString("dd\\/MM\\/yyyy");
      Console.WriteLine(dateTime2);

      string hour = DateTime.Now.ToString("HH:mm");
      Console.WriteLine(hour);

    }
  }
}
