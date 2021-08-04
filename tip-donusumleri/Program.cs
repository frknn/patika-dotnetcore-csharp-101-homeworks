using System;

namespace tip_donusumleri
{
  class Program
  {
    static void Main(string[] args)
    {
      // Implicit Conversion
      Console.Write("****** IMPLICIT CONV. ******\n");

      byte a = 5;
      sbyte b = 30;
      short c = 10;

      int d = a + b + c;
      Console.WriteLine("d: " + d);

      long h = d;
      Console.WriteLine("h: " + h);

      float f = h;
      Console.WriteLine("f: " + f);

      string str = "furkan";
      char x = 'c';
      object z = str + x + d;
      Console.WriteLine("z: " + z);


      // Explicit Conversion
      Console.Write("****** Explicit CONV. ******\n");

      int y = 4;
      byte by = (byte)y;
      Console.WriteLine("by: " + by);

      int j = 100;
      byte t = (byte)j;
      Console.WriteLine("t: " + t);

      float w = 10.3f;
      byte v = (byte)w;
      Console.WriteLine("v: " + v);

      Console.WriteLine("\n****** TO STRING ******\n");
      int xx = 6;
      string yy = xx.ToString();
      Console.WriteLine("yy: " + yy);

      string zz = 12.5f.ToString();
      Console.WriteLine("zz: " + zz);


      Console.WriteLine("\n****** System.Convert ******\n");
      string s1 = "10", s2 = "20";
      int sayi1, sayi2;
      int toplam;

      sayi1 = Convert.ToInt32(s1);
      sayi2 = Convert.ToInt32(s2);
      toplam = sayi1 + sayi2;

      Console.WriteLine("toplam: " + toplam);

      // Parse
      Console.WriteLine("\n****** Parse ******\n");
      ParseMethod();

    }
    public static void ParseMethod()
    {
      string metin1 = "10";
      string metin2 = "10,25";
      int rakam1;
      double double1;

      rakam1 = Int32.Parse(metin1);
      Console.WriteLine("rakam1: " + rakam1);
      double1 = Double.Parse(metin2);
      Console.WriteLine("double1: " + double1);
    }
  }
}
